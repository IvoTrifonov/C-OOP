﻿using ExerciseSOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseSOLID.Models
{
    public class XmlLayout : ILayout
    {
        public string Format => "<log>\n" +
            "   <date>{0}</date>\n" +
            "   <level>{1}</level>\n" +
            "   <message>{2}</message>\n" +
            "</log>";
    }
}
