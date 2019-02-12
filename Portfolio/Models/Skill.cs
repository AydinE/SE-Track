using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
	public class Skill
	{

		public long Id { get; set; }
		public string Name { get; set; }
		// Proficiency from 0 - 100 %
		public int Proficiency { get; set; }
	}
}
