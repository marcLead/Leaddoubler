using System;
using System.IO;
using System.Threading.Tasks;

namespace leaddoubler
{
	public interface IPicturePicker
	{
		Task<Stream> GetImageStreamAsync();
	}
}
