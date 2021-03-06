﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore21.Models
{
	public class Post
	{

		public int Id { get; set; }
		public string Title { get; set; }

		[DataType(DataType.Date)]
		public DateTime ReleaseDate { get; set; }
		public string Content { get; set; }

	}
}
