﻿// Decompiled with JetBrains decompiler
// Type: Mcafee.Program
// Assembly: Mcafee, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E8ABDF02-8A4A-421D-8941-056F8CA96A8B
// Assembly location: C:\Users\Administrateur\Downloads\Virusshare-00000-msil\Email-Worm.MSIL.Cabac.a-6a616d6396ea98af23899d1ef241f1987c0c048c5ff5c3600a97133b5e844b01.exe

using System;
using System.Windows.Forms;

namespace Mcafee
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new Form1());
    }
  }
}
