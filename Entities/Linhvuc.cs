﻿using System;
using System.Collections.Generic;

namespace back_end_c_sharp_test_with_friend_.Entities;

public partial class Linhvuc
{
    public string Tenlinhvuc { get; set; } = null!;

    public virtual ICollection<Sach> Saches { get; set; } = new List<Sach>();
}