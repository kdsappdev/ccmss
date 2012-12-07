using System;
using System.Runtime.InteropServices ;
using System.Collections.Generic ;
using System.Net ;
using System.Net.Sockets ;
using System.IO ;
namespace CCMS.Helpers
{	
	public class NetHelper
	{		 

		#region DownLoadFileFromUrl
        /// <summary>
        /// DownLoadFileFromUrl 将url处的文件下载到本地
        /// </summary>       
		public static void DownLoadFileFromUrl(string url ,string saveFilePath)
		{
			FileStream fstream  = new FileStream(saveFilePath ,FileMode.Create ,FileAccess.Write);
			WebRequest wRequest =  WebRequest.Create(url);

			try
			{				
				WebResponse wResponse = wRequest.GetResponse();	
				int contentLength =(int)wResponse.ContentLength;				
												
				byte[] buffer = new byte[1024];
				int read_count = 0 ;
				int total_read_count = 0 ;
				bool complete = false;							
				
				while (!complete )
				{
					read_count = wResponse.GetResponseStream().Read(buffer,0,buffer.Length);
					
					if(read_count > 0)
					{						
						fstream.Write(buffer ,0 ,read_count) ;
						total_read_count += read_count ;								
					}	
					else
					{
						complete = true ;
					}
				}
				
				fstream.Flush() ;				
			}			
			finally
			{				
				fstream.Close() ;				
				wRequest = null;
			}
		}
		#endregion
	}	
}
