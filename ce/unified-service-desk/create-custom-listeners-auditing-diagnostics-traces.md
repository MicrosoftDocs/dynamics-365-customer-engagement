---
title: "Create custom listeners for auditing, diagnostics and traces | MicrosoftDocs"
description: "Learn about creating custom listeners that lets you target the log output to files, the event log, or other sources. Until the previous version of Unified Service Desk, you could only use the standard listeners to write auditing, diagnostics, and trace logs in Unified Service Desk."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 12/31/2019
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-USD
search.audienceType: 
  - customizer
  - developer
search.app: 
  - D365CE
  - D365USD
---
# Create custom listeners for auditing, diagnostics and traces

[!INCLUDE[cc-data-platform-banner](../includes/cc-data-platform-banner.md)]

A listener lets you target the log output to files, the event log, or other sources. Until the previous version of [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)], you could only use the standard listeners to write auditing, diagnostics, and trace logs in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)].  
  
 With [!INCLUDE[pn_unified_service_desk_20](../includes/pn-unified-service-desk-20.md)], you can configure custom listeners to log auditing, diagnostics, and tracing data. Specify a custom listener by using the new type of hosted control called **Listener Hosted Control** that contains a reference to the assembly (.dll file) containing your custom listener code.  
  
<a name="What"></a>   
## What does creating custom listeners involve?  
 Creating and using custom listeners in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] involves developers and administrators working together. The following table outlines the process.  
  
|Step|Who does it?|Task|See here|  
|----------|------------------|----------|--------------|  
|1|Developer|Write code for your custom listener.|[Define your custom listener for Unified Service Desk](../unified-service-desk/create-custom-listeners-auditing-diagnostics-traces.md#Define)|  
|2|Developer|Compress assembly into a .zip file to create a customization file for Unified Service Desk.|[Prepare for distribution of your sample code](../unified-service-desk/create-custom-listeners-auditing-diagnostics-traces.md#Distribute)|  
|3|Developer/Administrator|Create instances of the **Listener Hosted Control** to use the custom listener code.|[Create Listener Hosted Control instances to use your custom listener code](../unified-service-desk/create-custom-listeners-auditing-diagnostics-traces.md#ListenerHostedControl)|  
|4|Administrator|Create instances of **Auditing & Diagnostics Settings** record to configure your auditing, diagnostics, or trace logging information.|[Configure auditing and diagnostics in Unified Service Desk](admin/configure-auditing-diagnostics-unified-service-desk.md)|  
|5|Administrator|Create **Customization Files**, and attach the .zip file created by the developer in step #2.|[Distribute custom hosted controls using Customization Files](admin/distribute-custom-hosted-controls-using-customization-files.md)|  
|6|Administrator|Attach the **Customization Files** record to the appropriate instance of the **Configuration** entity.|[Associate auditing and diagnostics with a configuration](admin/manage-access-using-unified-service-desk-configuration.md#auditanddiag)|  
  
<a name="Define"></a>   
## Define your custom listener for Unified Service Desk  
 You can combine the code for your custom listener for auditing, diagnostics, and trace logging into a single assembly or different assemblies. The class containing your listener code must be derived from:  
  
-   [IAuditService](https://docs.microsoft.com/dotnet/api/microsoft.uii.aifservices.iauditservice) for auditing logs  
  
-   [ILogging](https://docs.microsoft.com/dotnet/api/microsoft.uii.common.logging.ilogging) for diagnostic logs  
  
-   [TraceListener](https://msdn.microsoft.com/library/hy72797k.aspx) for trace logs  
  
> [!NOTE]
>  Make a note of the namespace and class names in your listener code. You will need these to create instances of Listener Hosted Control to refer to your custom code.  
  
<a name="CustomAudit"></a>   
### Custom Listener for Auditing Logs  
 The following sample code demonstrates how to create a custom listener that writes audit data to USDAudit.log file in the C:\USDLogs folder.  
  
```csharp  
using Microsoft.Uii.AifServices;  
using Microsoft.Uii.Common.Entities;  
using Microsoft.Uii.Common.Logging;  
using System;  
using System.Collections.Generic;  
using System.Configuration;  
using System.IO;  
using System.Linq;  
using System.Text;  
using System.Threading.Tasks;  
  
namespace SampleCustomUSDListener  
{  
    public class CustomUSDAuditListener : IAuditService  
    {  
        public void SaveAudit(IEnumerable<Microsoft.Uii.Common.Entities.LogData> logCache)  
        {  
            LogToFile(logCache);  
        }  
  
        private void LogToFile(IEnumerable<LogData> logCache)  
        {  
            string filename = Path.GetPathRoot(Environment.SystemDirectory) + "USDLogs\\USDAudit.log";  
            foreach (var item in logCache)  
            {  
                try  
                {  
                    File.AppendAllText(filename, item.GetLogData());  
                }  
                catch (Exception ex)  
                {   
                    Logging.Error("USD",ex.StackTrace);   
                }  
            }  
        }  
    }  
}  
  
```  
  
### Custom Listener for Diagnostic Logs  
 The following sample code demonstrates how to create a custom listener that writes diagnostic data to the USDDiagnostics.log file in the C:\USDLogs folder.  
  
```csharp  
using Microsoft.Uii.Common.Logging;  
using Microsoft.Uii.Common.Entities;  
using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
using System.IO;  
using System.Configuration;  
using System.Threading.Tasks;  
  
namespace SampleCustomUSDListener  
{  
    class CustomUSDDiagnosticListener : ILogging  
    {  
        string filename = Path.GetPathRoot(Environment.SystemDirectory) + "USDLogs\\USDDiagnostics.log";  
        public void Error(string applicationName, string message, string advanced)  
        {  
            File.AppendAllText(filename, "\nError is logged\n" + "\nApplication Name:\n" + applicationName + "\nMessage:\n" + message + "\nAdvanced:\n" + advanced);  
        }  
  
        public void Information(string applicationName, string message)  
        {  
            File.AppendAllText(filename, "\nInformation is logged\n" + "\nApplication Name:\n" + applicationName + "\nMessage:\n" + message);  
        }  
  
        public void Initialize(string name, System.Collections.Specialized.NameValueCollection configValue)  
        {  
            //Not needed  
        }  
  
        public bool ShowErrors  
        {  
            get  
            {  
                throw new NotImplementedException();  
            }  
            set  
            {  
                throw new NotImplementedException();  
            }  
        }  
  
        public string Tag  
        {  
            get  
            {  
                throw new NotImplementedException();  
            }  
            set  
            {  
                throw new NotImplementedException();  
            }  
        }  
  
        public void Trace(string applicationName, string message)  
        {  
            File.AppendAllText(filename, "\nVerbose is logged\n" + "\nApplication Name:\n" + applicationName + "\nMessage:\n" + message);  
        }  
  
        public void Warn(string applicationName, string message)  
        {  
            File.AppendAllText(filename, "\nWarning is logged\n" + "\nApplication Name:\n" + applicationName + "\nMessage:\n" + message);  
        }  
    }  
}  
```  
  
### Custom Listener for Trace Logs  
 The following sample code demonstrates how to create a custom listener that writes trace data to the USDTraces.log file in the C:\USDLogs folder.  
  
```csharp  
using System;  
using System.Diagnostics;  
using System.IO;  
  
namespace SampleCustomUSDListener  
{  
    class CustomUSDTraceListener : TraceListener  
    {  
        string filename = Path.GetPathRoot(Environment.SystemDirectory) + "USDLogs\\USDTraces.log";  
        public override void Write(string message)  
        {  
            File.AppendAllText(filename, message);  
        }  
  
        public override void WriteLine(string message)  
        {  
            File.AppendAllText(filename, message);  
        }  
    }  
}  
```  
  
<a name="Distribute"></a>   
## Prepare for distribution of your sample code  
 After you have built your custom listener code into an assembly (.dll) file, work with your administrator to distribute your code to the client computers so that they can consume your custom listeners. To distribute your custom files, compress the files along with a `[Content_Types].xml` file into a .zip file and provide the .zip file to you administrator to attach it to a `Customization Files` record. See [Next steps for administrator](../unified-service-desk/create-custom-listeners-auditing-diagnostics-traces.md#NextSteps).  
  
 The [Content_Types].xml file provides MIME type information of the file type extensions that are included in the .zip file. Typically, the file types are: .config, .dll, .exe, and .xml. However, you can include any file type that’s supported on Windows in the [Content_Types].xml file and in the zip file.  
  
 Here is a sample [Content_Types].xml file with file types listed that are typically used for customizing [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]:  
  
```xml  
<?xml version="1.0" encoding="utf-8"?>  
<Types xmlns="https://schemas.openxmlformats.org/package/2006/content-types">  
  <Default Extension="config" ContentType="application/octet-stream" />  
  <Default Extension="dll" ContentType="application/octet-stream" />  
  <Default Extension="exe" ContentType="application/octet-stream" />  
  <Default Extension="xml" ContentType="application/octet-stream" />  
</Types>  
```  
  
<a name="ListenerHostedControl"></a>   
## Create Listener Hosted Control instances to use your custom listener code  
 The new Listener hosted Control in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] lets you reference and use your custom listener code for logging data as per your code. The **Assembly Info** area in the new hosted control screen lets you specify the details about your assembly that you want to be referred to by the Listener Hosted Control. Specify your assembly (.dll) name in the **Assembly URI** field, and *\<AssemblyName>.\<ClassName>* in the **Assembly Type** field. The *\<ClassName>* should be the class that contains your code.
  
 For example, if we consider the sample code for custom listeners earlier in this topic and assuming that all the sample codes are compiled into a single assembly called SampleCustomUSDListener.dll, you must create a listener hosted control record each for audit, diagnostic, and trace with the following values in the **Assembly URI** and **Assembly Type** fields.  
  
|Audit|Diagnostic|Trace|  
|-----------|----------------|-----------|  
|- **Assembly URI**: SampleCustomUSDListener<br />- **Assembly Type**: SampleCustomUSDListener.CustomUSDAuditListener|- **Assembly URI**: SampleCustomUSDListener<br />- **Assembly Type**: SampleCustomUSDListener.CustomUSDDiagnosticListener|- **Assembly URI**: SampleCustomUSDListener<br />- **Assembly Type**: SampleCustomUSDListener.CustomUSDTraceListener|  
  
 Save the listener hosted control records.  
  
<a name="NextSteps"></a>   
## Next steps for administrator  
 As an administrator, you should now do the following two things to use the custom listener code in your organization:  
  
- Create **Auditing & Diagnostic Settings** records, and attach the appropriate listener hosted control record to it. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Configure auditing and diagnostics in Unified Service Desk](admin/configure-auditing-diagnostics-unified-service-desk.md)  
  
- Use the .zip file to create a **Customization Files** record and then attach it to the appropriate **Configuration** record so that the assembly can be distributed to the client computers when they sign in to  Dynamics 365 using the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] client. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Distribute custom hosted controls using Customization Files](admin/distribute-custom-hosted-controls-using-customization-files.md)  
  
### See also

 [Extend Unified Service Desk](../unified-service-desk/extend-unified-service-desk.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]