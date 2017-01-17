using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using GemBox.Spreadsheet;
using HomestayManagementSystemMigration.Models;

namespace HomestayManagementSystemMigration
{
    public partial class Form1 : Form
    {
        private readonly GemboxService _gembox;

        public Form1()
        {
            InitializeComponent();

            _gembox = new GemboxService();
        }

        private void buttonOpenExcelHomestay_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var excel = new ExcelFile();
                if (_gembox.isLoadFile(excel, openFileDialog1.FileName) == false) return;

                var homestays = new List<Homestay>();

                foreach (var worksheet in excel.Worksheets)
                {
                    var isFound = false;

                    for (var i = 1; i < worksheet.Rows.Count; i++)
                    {
                        var row = worksheet.Rows[i];

                        if (_gembox.getCellValue(row.Cells[0]).ToUpper() == "HOMESTAY FAMILY" &&
                            _gembox.getCellValue(row.Cells[1]).ToUpper() == "ADDRESS" &&
                            _gembox.getCellValue(row.Cells[2]).ToUpper() == "SCORE" &&
                            _gembox.getCellValue(row.Cells[3]).ToUpper() == "CONTRACT" &&
                            _gembox.getCellValue(row.Cells[4]).ToUpper() == "STUDENTS" &&
                            _gembox.getCellValue(row.Cells[5]).ToUpper() == "HOUSEHOLD" &&
                            _gembox.getCellValue(row.Cells[6]).ToUpper() == "POLICE CHECK" &&
                            _gembox.getCellValue(row.Cells[7]).ToUpper() == "LANGUAGE")
                        {
                            isFound = true;
                            continue;
                        }
                        if (isFound == false) continue;

                        if (_gembox.isBlankCheck(worksheet, i, 8))
                            break;

                        var homestayFamily = _gembox.getCellValue(row.Cells[0]).Trim();
                        var address = _gembox.getCellValue(row.Cells[1]).Trim();
                        var score = _gembox.getCellValue(row.Cells[2]).Trim();
                        var contract = _gembox.getCellValue(row.Cells[3]).Trim();
                        var students = _gembox.getCellValue(row.Cells[4]).Trim();
                        var household = _gembox.getCellValue(row.Cells[5]).Trim();
                        var policeCheck = _gembox.getCellValue(row.Cells[6]).Trim();
                        var language = _gembox.getCellValue(row.Cells[7]).Trim();

                        var firstName = string.Empty;
                        var lastName = string.Empty;
                        var homestayFamilyList = homestayFamily.Split(' ').ToList();
                        switch (homestayFamilyList.Count)
                        {
                            case 1:
                                firstName = homestayFamilyList[0];
                                break;
                            case 2:
                                firstName = homestayFamilyList[0];
                                lastName = homestayFamilyList[1];
                                break;
                            case 3:
                                firstName = homestayFamilyList[0];
                                lastName = homestayFamilyList[1] + " " + homestayFamilyList[2];
                                break;
                            case 4:
                                firstName = homestayFamilyList[0];
                                lastName = homestayFamilyList[1] + " " + homestayFamilyList[2] + " " + homestayFamilyList[3];
                                break;
                        }

                        if (string.IsNullOrEmpty(firstName) && string.IsNullOrEmpty(lastName))
                            continue;

                        if (!homestays.Any(x => x.FirstName == firstName && x.LastName == lastName && x.Address == address))
                        {
                            var homestay = new Homestay();

                            // household
                            foreach (var hh in Regex.Split(household, "\r\n"))
                            {
                                var houseHold = new HouseHold();
                                var hhSplit = hh.Split(' ').ToList();
                                var isGood = true;

                                switch (hhSplit.Count)
                                {
                                    case 2:
                                        houseHold.FirstName = hhSplit[0];

                                        houseHold.BirthDay = hhSplit[1].Contains(".") ? hhSplit[1].Replace(".", "-").Replace("(", string.Empty).Replace(")", string.Empty) : "01-01-1990";
                                        break;
                                    case 3:
                                        houseHold.FirstName = hhSplit[0];
                                        houseHold.LastName = hhSplit[1];

                                        houseHold.BirthDay = hhSplit[2].Contains(".") ? hhSplit[2].Replace(".", "-").Replace("(", string.Empty).Replace(")", string.Empty) : "01-01-1990";
                                        break;
                                    case 4:
                                        houseHold.FirstName = hhSplit[0];
                                        houseHold.LastName = hhSplit[1] + " " + hhSplit[2];

                                        houseHold.BirthDay = hhSplit[3].Contains(".") ? hhSplit[3].Replace(".", "-").Replace("(", string.Empty).Replace(")", string.Empty) : "01-01-1990";
                                        break;
                                    case 5:
                                        houseHold.FirstName = hhSplit[0];
                                        houseHold.LastName = hhSplit[1] + " " + hhSplit[2] + " " + hhSplit[3];

                                        houseHold.BirthDay = hhSplit[4].Contains(".") ? hhSplit[4].Replace(".", "-").Replace("(", string.Empty).Replace(")", string.Empty) : "01-01-1990";
                                        break;
                                    default:
                                        isGood = false;
                                        break;
                                }
                                if (isGood)
                                    homestay.Household.Add(houseHold);
                            }

                            // police check
                            foreach (var pc in Regex.Split(policeCheck, "\r\n"))
                            {
                                if (!string.IsNullOrEmpty(pc))
                                    homestay.PoliceCheck.Add(pc.Trim());
                            }

                            homestay.FirstName = firstName;
                            homestay.LastName = lastName;
                            homestay.Address = address;
                            homestay.Score = score;
                            homestay.Contract = contract;
                            homestay.Students = students;
                            homestay.Language = language;

                            homestays.Add(homestay);
                        }
                    }
                }

                var sb = new StringBuilder();
                foreach (var homestay in homestays)
                {
                    sb.AppendLine($"");

                    sb.AppendLine($"new Homestay() {{ FirstName = \"{homestay.FirstName}\", LastName = \"{homestay.LastName}\", Address = \"{homestay.Address}\", Language = \"{homestay.Language}\", Students = \"{homestay.Students}\", Phone = \"(111) 111-1111\", PostCode = \"A1A1A1\", Room = 0, VideoUrl = \"\", CreatedDate = DateTime.Now, CreatedUserId = 1,");

                    if (!string.IsNullOrEmpty(homestay.Score))
                        sb.AppendLine($"\tHomestayEvaluations = new List<HomestayEvaluation>() {{ new HomestayEvaluation() {{ EvaluationDate = DateTime.Now, Location = {homestay.Score}, CreatedDate = DateTime.Now, CreatedUserId = 1 }} }},");

                    if (!string.IsNullOrEmpty(homestay.Contract))
                        sb.AppendLine($"\tHomestayContracts = new List<HomestayContract>() {{ new HomestayContract() {{ ContractDate = DateTime.Parse(\"{homestay.Contract}\"), CreatedDate = DateTime.Now, CreatedUserId = 1 }} }},");

                    if (homestay.Household.Count > 0)
                    {
                        sb.AppendLine("\tHomestayHouseHolds = new List<HomestayHouseHold>() { ");

                        foreach (var houseHold in homestay.Household)
                        {
                            sb.AppendLine($"\t\tnew HomestayHouseHold() {{ FirstName = \"{houseHold.FirstName}\", LastName = \"{houseHold.LastName}\", Birthday = DateTime.Parse(\"{houseHold.BirthDay}\"), Gender = true, CreatedDate = DateTime.Now, CreatedUserId = 1 }},");
                        }

                        sb.AppendLine("\t},");
                    }

                    if (homestay.PoliceCheck.Count > 0)
                    {
                        sb.AppendLine("\tHomestayPoliceChecks = new List<HomestayPoliceCheck>() { ");

                        foreach (var policeCheck in homestay.PoliceCheck)
                        {
                            sb.AppendLine($"\t\tnew HomestayPoliceCheck() {{ PoliceCheckDate = DateTime.Parse(\"{policeCheck}\"), CreatedDate = DateTime.Now, CreatedUserId = 1 }},");
                        }

                        sb.AppendLine("\t},");
                    }

                    sb.AppendLine("},");
                }

                richTextBoxResult.Text = sb.ToString();
                MessageBox.Show(@"Homestay Done");
            }
        }

        private void buttonOpenExcelStudent_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var excel = new ExcelFile();
                if (_gembox.isLoadFile(excel, openFileDialog1.FileName) == false) return;

                var students = new List<Student>();

                foreach (var worksheet in excel.Worksheets)
                {
                    var isFound = false;

                    for (var i = 0; i < worksheet.Rows.Count; i++)
                    {
                        var row = worksheet.Rows[i];

                        if (_gembox.getCellValue(row.Cells[0]).ToUpper() == "HOMESTAY FAMILY" &&
                            _gembox.getCellValue(row.Cells[1]).ToUpper() == "STUDENT LAST NAME" &&
                            _gembox.getCellValue(row.Cells[2]).ToUpper() == "STUDENT FIRST NAME" &&
                            _gembox.getCellValue(row.Cells[3]).ToUpper() == "GENDER" &&
                            _gembox.getCellValue(row.Cells[4]).ToUpper() == "ARRIVAL" &&
                            _gembox.getCellValue(row.Cells[5]).ToUpper() == "DEPARTURE" &&
                            _gembox.getCellValue(row.Cells[6]).ToUpper() == "AMOUNT OWING" &&
                            _gembox.getCellValue(row.Cells[7]).ToUpper() == "AMOUNT PAID")
                        {
                            isFound = true;
                            continue;
                        }
                        if (isFound == false) continue;

                        if (_gembox.isBlankCheck(worksheet, i, 8))
                            break;

                        var studentLastName = _gembox.getCellValue(row.Cells[1]).Trim();
                        var studentFirstName = _gembox.getCellValue(row.Cells[2]).Trim();
                        var gender = _gembox.getCellValue(row.Cells[3]).Trim();
                        var siteLocation = string.Empty;

                        if (string.IsNullOrEmpty(studentLastName) && string.IsNullOrEmpty(studentFirstName))
                            continue;

                        gender = gender.ToUpper() == "F" ? "false" : "true";

                        if (worksheet.Name.ToUpper().Contains("SEC") && worksheet.Name.ToUpper().Contains("TOR"))
                            siteLocation = "secToronto";
                        else if (worksheet.Name.Contains("CAC") && worksheet.Name.ToUpper().Contains("TOR"))
                            siteLocation = "cacToronto";
                        else if (worksheet.Name.ToUpper().Contains("PGIC") && worksheet.Name.ToUpper().Contains("TOR"))
                            siteLocation = "pgicToronto";
                        else if (worksheet.Name.ToUpper().Contains("KGIC") && worksheet.Name.ToUpper().Contains("TOR"))
                            siteLocation = "kgicToronto";
                        else if (worksheet.Name.ToUpper().Contains("SEC") && worksheet.Name.ToUpper().Contains("VAN"))
                            siteLocation = "secVancouver";
                        else if (worksheet.Name.ToUpper().Contains("KGIC") && worksheet.Name.ToUpper().Contains("SUR"))
                            siteLocation = "kgicSurrey";
                        else if (worksheet.Name.ToUpper().Contains("KGIC") && worksheet.Name.ToUpper().Contains("VAN"))
                            siteLocation = "kgicVancouver";
                        else if (worksheet.Name.ToUpper().Contains("KGIC") && worksheet.Name.ToUpper().Contains("VIC"))
                            siteLocation = "kgicVictoria";
                        else if (worksheet.Name.ToUpper().Contains("PGIC") && worksheet.Name.ToUpper().Contains("VAN"))
                            siteLocation = "pgicVancouver";

                        if (!students.Any(x => x.FirstName == studentFirstName && x.LastName == studentLastName && x.Gender == gender && x.SiteLocation == siteLocation))
                        {
                            students.Add(new Student()
                            {
                                LastName = studentLastName,
                                FirstName = studentFirstName,
                                Gender = gender,
                                SiteLocation = siteLocation
                            });
                        }
                    }
                }

                var sb = new StringBuilder();
                foreach (var student in students)
                {
                    sb.AppendLine($"");

                    sb.AppendLine($"new Student() {{ FirstName = \"{student.FirstName}\", LastName = \"{student.LastName}\", Address = string.Empty, PostCode = \"A1A1A1\", Gender = {student.Gender}, Phone = \"(111) 111-1111\", SiteLocation = {student.SiteLocation}, StudentNo = \"0000\", CreatedDate = DateTime.Now }},");
                }

                richTextBoxResult.Text = sb.ToString();
                MessageBox.Show(@"Student Done");
            }
        }

        private void buttonOpenExcelHomestayStudent_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var excel = new ExcelFile();
                if (_gembox.isLoadFile(excel, openFileDialog1.FileName) == false) return;

                var homestayStudents = new List<HomestayStudent>();

                foreach (var worksheet in excel.Worksheets)
                {
                    var isFound = false;

                    for (var i = 0; i < worksheet.Rows.Count; i++)
                    {
                        var row = worksheet.Rows[i];

                        if (_gembox.getCellValue(row.Cells[0]).ToUpper() == "HOMESTAY FAMILY" &&
                            _gembox.getCellValue(row.Cells[1]).ToUpper() == "STUDENT LAST NAME" &&
                            _gembox.getCellValue(row.Cells[2]).ToUpper() == "STUDENT FIRST NAME" &&
                            _gembox.getCellValue(row.Cells[3]).ToUpper() == "GENDER" &&
                            _gembox.getCellValue(row.Cells[4]).ToUpper() == "ARRIVAL" &&
                            _gembox.getCellValue(row.Cells[5]).ToUpper() == "DEPARTURE" &&
                            _gembox.getCellValue(row.Cells[6]).ToUpper() == "AMOUNT OWING" &&
                            _gembox.getCellValue(row.Cells[7]).ToUpper() == "AMOUNT PAID")
                        {
                            isFound = true;
                            continue;
                        }
                        if (isFound == false) continue;

                        if (_gembox.isBlankCheck(worksheet, i, 8))
                            break;

                        var homestayFamily = _gembox.getCellValue(row.Cells[0]).Trim();
                        var studentLastName = _gembox.getCellValue(row.Cells[1]).Trim();
                        var studentFirstName = _gembox.getCellValue(row.Cells[2]).Trim();
                        var gender = _gembox.getCellValue(row.Cells[3]).Trim();
                        var arrival = _gembox.getCellValue(row.Cells[4]).Trim();
                        var departure = _gembox.getCellValue(row.Cells[5]).Trim();
                        var amountOwing = _gembox.getCellValue(row.Cells[6]).Trim();
                        var amountPaid = _gembox.getCellValue(row.Cells[7]).Trim();

                        if (string.IsNullOrEmpty(arrival) || string.IsNullOrEmpty(departure))
                            continue;

                        var firstName = string.Empty;
                        var lastName = string.Empty;
                        var homestayFamilyList = homestayFamily.Split(' ').ToList();
                        switch (homestayFamilyList.Count)
                        {
                            case 1:
                                firstName = homestayFamilyList[0];
                                break;
                            case 2:
                                firstName = homestayFamilyList[0];
                                lastName = homestayFamilyList[1];
                                break;
                            case 3:
                                firstName = homestayFamilyList[0];
                                lastName = homestayFamilyList[1] + " " + homestayFamilyList[2];
                                break;
                            case 4:
                                firstName = homestayFamilyList[0];
                                lastName = homestayFamilyList[1] + " " + homestayFamilyList[2] + " " + homestayFamilyList[3];
                                break;
                        }

                        gender = gender.ToUpper() == "F" ? "false" : "true";
                        var siteLocation = string.Empty;

                        if (worksheet.Name.ToUpper().Contains("SEC") && worksheet.Name.ToUpper().Contains("TOR"))
                            siteLocation = "secToronto";
                        else if (worksheet.Name.Contains("CAC") && worksheet.Name.ToUpper().Contains("TOR"))
                            siteLocation = "cacToronto";
                        else if (worksheet.Name.ToUpper().Contains("PGIC") && worksheet.Name.ToUpper().Contains("TOR"))
                            siteLocation = "pgicToronto";
                        else if (worksheet.Name.ToUpper().Contains("KGIC") && worksheet.Name.ToUpper().Contains("TOR"))
                            siteLocation = "kgicToronto";
                        else if (worksheet.Name.ToUpper().Contains("SEC") && worksheet.Name.ToUpper().Contains("VAN"))
                            siteLocation = "secVancouver";
                        else if (worksheet.Name.ToUpper().Contains("KGIC") && worksheet.Name.ToUpper().Contains("SUR"))
                            siteLocation = "kgicSurrey";
                        else if (worksheet.Name.ToUpper().Contains("KGIC") && worksheet.Name.ToUpper().Contains("VAN"))
                            siteLocation = "kgicVancouver";
                        else if (worksheet.Name.ToUpper().Contains("KGIC") && worksheet.Name.ToUpper().Contains("VIC"))
                            siteLocation = "kgicVictoria";
                        else if (worksheet.Name.ToUpper().Contains("PGIC") && worksheet.Name.ToUpper().Contains("VAN"))
                            siteLocation = "pgicVancouver";

                        var homestayStudent = new HomestayStudent();
                        homestayStudent.Homestay.FirstName = firstName;
                        homestayStudent.Homestay.LastName = lastName;
                        homestayStudent.Student.FirstName = studentFirstName;
                        homestayStudent.Student.LastName = studentLastName;
                        homestayStudent.Student.Gender = gender;
                        homestayStudent.Arrival = arrival;
                        homestayStudent.Departure = departure;
                        homestayStudent.AmountOwing = amountOwing;
                        homestayStudent.AmountPaid = amountPaid;
                        homestayStudent.SiteLocation = siteLocation;

                        homestayStudents.Add(homestayStudent);
                    }
                }

                var sb = new StringBuilder();
                foreach (var homestayStudent in homestayStudents)
                {
                    sb.AppendLine($"");

                    sb.AppendLine($"student = _context.Students.FirstOrDefault(x => x.FirstName == \"{homestayStudent.Student.FirstName}\" && x.LastName == \"{homestayStudent.Student.LastName}\" && x.Gender == {homestayStudent.Student.Gender} && x.SiteLocation == {homestayStudent.SiteLocation});");

                    sb.AppendLine("if (student != null)");
                    sb.AppendLine("{");

                    sb.AppendLine($"\thomestay = _context.Homestays.FirstOrDefault(x => x.FirstName == \"{homestayStudent.Homestay.FirstName}\" && x.LastName == \"{homestayStudent.Homestay.LastName}\");");

                    sb.AppendLine("\tif (homestay != null)");
                    sb.AppendLine("\t{");

                    sb.AppendLine($"\t\thomestayStudent = new HomestayStudent() {{ Arrival = DateTime.Parse(\"{homestayStudent.Arrival}\"), Departure = DateTime.Parse(\"{homestayStudent.Departure}\"), DueDate = DateTime.Parse(\"01-01-1900\"), PaidAmount = {(string.IsNullOrEmpty(homestayStudent.AmountPaid) ? "0" : homestayStudent.AmountPaid)}M, Amount = {(string.IsNullOrEmpty(homestayStudent.AmountOwing) ? "0" : homestayStudent.AmountOwing)}M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = student, Homestay = homestay }};");
                    sb.AppendLine("\t\t_context.HomestayStudents.Add(homestayStudent);");

                    sb.AppendLine("\t}");

                    sb.AppendLine("}");


                    //sb.AppendLine($"new HomestayStudent() {{ Arrival = DateTime.Parse(\"{homestayStudent.Arrival}\"), Departure = DateTime.Parse(\"{homestayStudent.Departure}\"), DueDate = DateTime.Parse(\"01-01-1900\"), PaidAmount = {(string.IsNullOrEmpty(homestayStudent.AmountPaid) ? "0" : homestayStudent.AmountPaid)}M, Amount = {(string.IsNullOrEmpty(homestayStudent.AmountOwing) ? "0" : homestayStudent.AmountOwing)}M, PaidDate = null, CreatedDate = DateTime.Now, CreatedUserId = 1, Student = _context.Students.FirstOrDefault(x=>x.FirstName == \"{homestayStudent.Student.FirstName}\" && x.LastName == \"{homestayStudent.Student.LastName}\" && x.Gender == {homestayStudent.Student.Gender} && x.SiteLocation == {homestayStudent.SiteLocation}), Homestay = _context.Homestays.FirstOrDefault(x=>x.FirstName == \"{homestayStudent.Homestay.FirstName}\" && x.LastName == \"{homestayStudent.Homestay.LastName}\") }},");
                }

                richTextBoxResult.Text = sb.ToString();
                MessageBox.Show(@"HomestayStudent Done");
            }
        }

    }
}
