﻿using RemObjects.Elements.RTL;

namespace RemObjects.InternetPack.Shared.Base
{    
    public abstract class TextReader:  MarshalByRefObject, IDisposable
    {                
        void Dispose()
        {

        }
        
        public virtual void Flush()
        {

        }

        public virtual string ReadToEnd()
        {

        }

        public virtual void Write(string Value)
        {

        }    
    }
    
    public class StreamReader : TextReader
    {
        public StreamReader(Stream stream)
        {

        }

        public override string ReadToEnd()
        {

        }

    }

    public class StreamWriter : TextReader
    {
        public StreamWriter(Stream Value)
        {
         
        }

        public override void Flush()
        {

        }
        
        public virtual void WriteLine()
        {

        }
        
        public virtual void WriteLine(string Value)
        {
            
        }

        public override void Write(string Value)
        {

        }
    }

    #if echoes
    public class WrappedStream: System.IO.Stream
    {
        private Stream fStream;

        public WrappedStream(Stream Input)
        {
            fStream = Input;
        }

		public override void Flush()
		{
            fStream.Flush();
		}

		public override void Close()
		{
            fStream.Close();
		}

		public override Int32 Read(Byte[] buffer, Int32 offset, Int32 size)
		{
            return fStream.Read(buffer, offset, size);
		}

		public override void Write(Byte[] buffer, Int32 offset, Int32 size)
		{
            fStream.Write(buffer, offset, size);
		}

        public override Int64 Seek(Int64 offset, PlatformSeekOrigin origin)
        {            
            return fStream.Seek(offset, (SeekOrigin)origin);
        }
		
		public override Boolean CanRead
		{
			get
			{
				return fStream.CanRead;
			}
		}

		public override Boolean CanSeek
		{
			get
			{
				return fStream.CanSeek;
			}
		}

		public override Boolean CanWrite
		{
			get
			{
				return fStream.CanWrite;
			}
		}

		public override void SetLength(Int64 length)
		{
			
		}

        public override Int64 Length
		{
			get
			{
			  return fStream.GetLength();	
			}
		}

		public override Int64 Position
		{
			get
			{
			  return fStream.GetPosition();	
			}

			set
			{
                fStream.SetPosition(value);
			}
        }
    }
    #endif
}