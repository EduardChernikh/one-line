﻿using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace OneLine {
	internal class MetaSlice : Slice {
		public int Before { get; set; }
		public int After { get; set; }

		public MetaSlice(int before, int after, Action<Rect> draw)
		: this(before, after, draw, null){
		}

		public MetaSlice(int before, int after, Action<Rect> draw, Action<Rect> drawHeader) 
		: base (0, 0, draw, drawHeader) {
			Before = before;
			After = after;
		}
	}
}