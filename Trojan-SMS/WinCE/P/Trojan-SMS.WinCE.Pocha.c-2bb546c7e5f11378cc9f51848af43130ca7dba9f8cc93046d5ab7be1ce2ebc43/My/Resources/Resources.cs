﻿// Decompiled with JetBrains decompiler
// Type: viconect.My.Resources.Resources
// Assembly: viconect, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0595134F-28B6-447C-9941-5F1051DDA774
// Assembly location: C:\Users\Administrateur\Downloads\Virusshare-00001-msil\Trojan-SMS.WinCE.Pocha.c-2bb546c7e5f11378cc9f51848af43130ca7dba9f8cc93046d5ab7be1ce2ebc43.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel;
using System.Globalization;
using System.Resources;

namespace viconect.My.Resources
{
  [StandardModule]
  [HideModuleName]
  internal sealed class Resources
  {
    private static ResourceManager _resMgr;
    private static CultureInfo _resCulture;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (viconect.My.Resources.Resources._resMgr == null)
          viconect.My.Resources.Resources._resMgr = new ResourceManager("viconect.Resources", typeof (viconect.My.Resources.Resources).Assembly);
        return viconect.My.Resources.Resources._resMgr;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => viconect.My.Resources.Resources._resCulture;
      set => viconect.My.Resources.Resources._resCulture = value;
    }
  }
}
