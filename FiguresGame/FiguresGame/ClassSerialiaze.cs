using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Security.AccessControl;
using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json;

namespace FiguresGame
{
   public static class ClassSerialiaze
   {
       #region Serialiaze XML
       public static void SerialiazeToXml<T>(ref T inObject, string inFileName)
       {
           try
           {
               System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(T));
               System.IO.StreamWriter file = new System.IO.StreamWriter(inFileName);
               writer.Serialize(file, inObject);
               file.Close();
           }
           catch (Exception ex) { MessageBox.Show(ex.Message); }
       }
       public static void SerialiazeToXml<T>( T inObject, string inFileName)
       {
           try
           {
               System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(T));
               System.IO.StreamWriter file = new System.IO.StreamWriter(inFileName);
               writer.Serialize(file, inObject);
               file.Close();
           }
           catch (Exception ex) { MessageBox.Show(ex.Message); }
       }

       public static void DeserializationFromXml<T>(ref T inObject, string inFileName)
       {
           if (System.IO.File.Exists(inFileName))
           {
               System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(T));
               System.IO.StreamReader file = new System.IO.StreamReader(inFileName);
               inObject = (T)reader.Deserialize(file);
               file.Close();
           }
       }
       public static void DeserializationFromXml<T>( T inObject, string inFileName)
       {
           if (System.IO.File.Exists(inFileName))
           {
               System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(T));
               System.IO.StreamReader file = new System.IO.StreamReader(inFileName);
               inObject = (T)reader.Deserialize(file);
               file.Close();
           }
       }
       #endregion



       #region Serialiaze Soap
       public static void SerialiazeToSoap<B>(ref B inObject, string inFileName)
       {
           try
           {
               var s = new FileStream(inFileName, FileMode.Create);
               SoapFormatter sf = new SoapFormatter();
               sf.Serialize(s, inObject);
               s.Close();
           }
           catch (Exception ex) { MessageBox.Show(ex.Message); }
       }
       public static void SerialiazeToSoap<B>(B inObject, string inFileName)
       {
           try
           {
               var s = new FileStream(inFileName, FileMode.Create);
               SoapFormatter sf = new SoapFormatter();
               sf.Serialize(s, inObject);
               s.Close();
           }
           catch (Exception ex) { MessageBox.Show(ex.Message); }
       }

       public static void DeserializationFromSoap<B>(ref B inObject, string inFileName)
       {
           if (System.IO.File.Exists(inFileName))
           {
               var s = new FileStream(inFileName, FileMode.Open);
               SoapFormatter sf = new SoapFormatter();
               inObject = (B)sf.Deserialize(s);
               s.Close();
           }
       }
       public static void DeserializationFromSoap<B>(B inObject, string inFileName)
       {
           if (System.IO.File.Exists(inFileName))
           {
               var s = new FileStream(inFileName, FileMode.Open);
               SoapFormatter sf = new SoapFormatter();
               inObject = (B)sf.Deserialize(s);
               s.Close();
           }
       }
       #endregion

     

       #region Serialiaze BIN
       public static void SerialiazeToBIN<I>(ref I inObject, string inFileName)
       {
           try
           {
               FileStream fstream = File.Open(inFileName, FileMode.Create);
               BinaryFormatter binaryFormatter = new BinaryFormatter();
               binaryFormatter.Serialize(fstream, inObject);
               fstream.Close();
           }
           catch (Exception ex) { MessageBox.Show(ex.Message); }
       }
       public static void SerialiazeToBIN<I>(I inObject, string inFileName)
       {
           try
           {
               FileStream fstream = File.Open(inFileName, FileMode.Create);
               BinaryFormatter binaryFormatter = new BinaryFormatter();
               binaryFormatter.Serialize(fstream, inObject);
               fstream.Close();
           }
           catch (Exception ex) { MessageBox.Show(ex.Message); }
       }

       public static void DeserializationFromBIN<I>(ref I inObject, string inFileName)
       {
           if (System.IO.File.Exists(inFileName))
           {
               FileStream fstream = File.Open(inFileName, FileMode.Open);
               BinaryFormatter binaryFormatter = new BinaryFormatter();
               inObject = (I)binaryFormatter.Deserialize(fstream);
               fstream.Close();
           }
       }
       public static void DeserializationFromBIN<I>(I inObject, string inFileName)
       {
           if (System.IO.File.Exists(inFileName))
           {
               FileStream fstream = File.Open(inFileName, FileMode.Open);
               BinaryFormatter binaryFormatter = new BinaryFormatter();
               inObject = (I)binaryFormatter.Deserialize(fstream);
               fstream.Close();
           }
       }
       #endregion



       #region Serialize Json
       public static void SerialiazeToJson<J>(ref J inObject, string inFileName)
       {
           try
           {
               DataContractJsonSerializer jsonWriter = new DataContractJsonSerializer(typeof(J));
               FileStream jsonWriterFile = new FileStream(inFileName, FileMode.Create);
               jsonWriter.WriteObject(jsonWriterFile, inObject);
               jsonWriterFile.Close();
           }
           catch (Exception ex) { MessageBox.Show(ex.Message); }
       }
       public static void SerialiazeToJson<J>(J inObject, string inFileName)
       {
           try
           {
               DataContractJsonSerializer jsonWriter = new DataContractJsonSerializer(typeof(J));
               FileStream jsonWriterFile = new FileStream(inFileName, FileMode.Create);
               jsonWriter.WriteObject(jsonWriterFile, inObject);  
               jsonWriterFile.Close();
           }
           catch (Exception ex) { MessageBox.Show(ex.Message); }
       }

       public static void DeserializationFromJson<J>(ref J inObject, string inFileName)
       {
           if (System.IO.File.Exists(inFileName))
           {
               DataContractJsonSerializer jsonReader = new DataContractJsonSerializer(typeof(J));
               FileStream file = new FileStream(inFileName, FileMode.Open);
               inObject = (J)jsonReader.ReadObject(file);
               file.Close();
           }
       }
       public static void DeserializationFromJson<J>(J inObject, string inFileName)
       {
           if (System.IO.File.Exists(inFileName))
           {
               DataContractJsonSerializer jsonReader = new DataContractJsonSerializer(typeof(J));
               FileStream file = new FileStream(inFileName, FileMode.Open);
               inObject = (J)jsonReader.ReadObject(file);
               file.Close();
           }
       }
       #endregion
   }
}