using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Net.Mail;
using System.Net;

namespace _2_BUS_Layer.Utility
{
    public class utility
    {
        public string MaHoaPass(string password)
        {
            //Tạo MD5 
            MD5 mh = MD5.Create();
            //Chuyển kiểu chuổi thành kiểu byte
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(password);
            //mã hóa chuỗi đã chuyển
            byte[] hash = mh.ComputeHash(inputBytes);
            //tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }

            return sb.ToString();
        }
        public string PassRandom()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";//String char for random password

            var random = new Random();
            // set string password random none repeat have length equals 6
            var randomString = new string(Enumerable.Repeat(chars, 8)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            return randomString;
        }
        public string SenderMail(string Mail)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 25);
                NetworkCredential cred = new NetworkCredential("luulvph13892@fpt.edu.vn", "developer102");
                MailMessage mgs = new MailMessage();
                mgs.From = new MailAddress("huyenvtph17141@fpt.edu.vn");
                mgs.To.Add("luulvph13892@fpt.edu.vn");
                mgs.Subject = "ban da su dung tinh nang quen mat khau";
                mgs.Body = "chao anh/chi .mat khau moi truy cap phan mem la " + 123;
                client.Credentials = cred;
                client.EnableSsl = true;
                client.Send(mgs);
                return "send mail sucessful";
            }
            catch (Exception)
            {
                return "send mail error";
            }
        }
    }
}
