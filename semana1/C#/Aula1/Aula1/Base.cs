using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MetodosNumericos
{
    public class Base
    {
		public double Numero { get; internal set; }
		public dynamic NumeroCalculado { get; internal set; }
		public string Expression { get; internal set; }
		public double Result { get; set; }		
	}
}
