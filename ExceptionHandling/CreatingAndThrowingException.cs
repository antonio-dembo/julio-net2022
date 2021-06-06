using System;
using System.IO;
using System.Runtime.Serialization;

namespace ExceptionHandling
{
  public class ProgramLog
  {
    FileStream logfile = null;

    public void OpenLog(FileInfo fileName, FileMode mode) { }

    public void WriteLog()
    {
      if (!logfile.CanWrite)
      {
        throw new InvalidOperationException("Logfile cannot be read-only");
      }
    }
    // Else write data to the log and return 
  }

  [Serializable]
  public class InvalidDepartmentException : Exception
  {
    public InvalidDepartmentException() : base() { }
    public InvalidDepartmentException(string message) : base(message) { }
    public InvalidDepartmentException(string message, Exception inner) { }

    // A constructor is needed for serialization when an
    // exception propagates from a remoting server to the client.
    protected InvalidDepartmentException(SerializationInfo info, StreamingContext context) : base(info, context) {}

  }

}