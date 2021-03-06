using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Alchemy4Tridion.Plugins.Clients.CoreService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(WrapperName = "UploadResponse", WrapperNamespace = "http://www.sdltridion.com/ContentManager/CoreService/201501", IsWrapped = true)]
	public class UploadResponse201501 : IUploadResponse
	{
		[MessageHeader(Namespace = "http://www.sdltridion.com/ContentManager/CoreService/201501")]
		public string FilePath;

		public UploadResponse201501()
		{
		}

		public UploadResponse201501(string FilePath)
		{
			this.FilePath = FilePath;
		}
	}
}
