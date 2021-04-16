---
title: "Integrate with Citrix applications in Unified Service Desk | MicrosoftDocs"
description: "The topic explains the integration with Citrix application in Unified service Desk."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 01/21/2020
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
# Integrate with Citrix applications in Unified Service Desk

[!INCLUDE[cc-data-platform-banner](../includes/cc-data-platform-banner.md)]

> [!Note]
> Hosting Citrix applications within Unified Service Desk isn't supported anymore.

Integrate your [!INCLUDE[pn_citrix](../includes/pn-citrix.md)] applications with [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] by hosting them in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]. This enables customer service agents to interact with the [!INCLUDE[pn_citrix](../includes/pn-citrix.md)] applications from within the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] client while working on the customer data in Microsoft Dataverse. You can configure a Windows application as a virtual application on Citrix XenApp 7.6 that runs as a hosted application in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]. More information: [Software requirements for Citrix XenApp application virtualization](admin/unified-service-desk-system-requirements.md#software-requirements-for-citrix-xenapp-application-virtualization)  
  
 The [!INCLUDE[pn_citrix](../includes/pn-citrix.md)] application hosted  in the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] client uses the Independent Computing Architecture (ICA) protocol to remotely communicate with the application on a [!INCLUDE[pn_citrix](../includes/pn-citrix.md)] server. A Citrix .ica file contains information to connect to the remote server  such as the server address, session properties, and authentication information.  
  
 For more information about integrating [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] with [!INCLUDE[pn_citrix](../includes/pn-citrix.md)], see [Blog: Citrix and Unified Service Desk](/archive/blogs/usd/citrix-and-unified-service-desk)  
  
 This topic provides information about configuring server- and client-side components for integrating [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] with [!INCLUDE[pn_citrix](../includes/pn-citrix.md)] applications, sample [!INCLUDE[pn_citrix](../includes/pn-citrix.md)] adapters, and some best practices.  
  
<a name="ServerSide"></a>   
## Configure server-side component for Citrix integration  
 The server-side component is implemented as an executable (Microsoft.Uii.Csr.CitrixIntegration.exe) that is configured as a startup program to automatically start when a [!INCLUDE[pn_citrix](../includes/pn-citrix.md)] application starts. The executable quickly self-terminates if the [!INCLUDE[pn_citrix](../includes/pn-citrix.md)] application has not been invoked from a [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] client. The server-side component needs to be configured on each [!INCLUDE[pn_citrix](../includes/pn-citrix.md)] server.  
  
1. [Download](https://go.microsoft.com/fwlink/p/?LinkId=519179) the [!INCLUDE[pn_user_inteface_integration_uii](../includes/pn-user-interface-integration-uii.md)] SDK package.  
  
2. Double-click the package file to extract the contents.  
  
3. Navigate to the `<ExtractedFolder>\UII\Bin\UII\Citrix Server Component` folder, and then copy all the files under this folder to a folder (e.g. ServerSideComponent) on your Citrix server.  
  
4. In the ServerSideComponent folder on your [!INCLUDE[pn_citrix](../includes/pn-citrix.md)] server, edit the `RegPatch Install StartupPrograms on Citrix Server.reg` file using Notepad to set the value of the "StartupPrograms" parameter to the full file path of the Microsoft.Uii.Csr.CitrixIntegration.exe executable file.  
  
5. Apply the registry patch on your [!INCLUDE[pn_citrix](../includes/pn-citrix.md)] server by running the `RegPatch Install StartupPrograms on Citrix Server.reg` file. This registry patch designates an executable as a startup program that will be launched alongside a [!INCLUDE[pn_citrix](../includes/pn-citrix.md)] application.  
  
<a name="ClientSide"></a>   
## Configure client-side component for Citrix integration  
 The client-side configuration for [!INCLUDE[pn_citrix](../includes/pn-citrix.md)] integration involves two things:  
  
- Configure a UII hosted application (`Remote Hosted Application`) instance in your Dataverse instance that can be used directly without any custom code, or can be extended as required. Actions fired on the UII hosted application instances are transmitted to the server-side component using a .ica file, where it is dispatched to the application adapters configured, if any. For more information about UII hosted applications, see [UII hosted applications](../unified-service-desk/uii-hosted-applications.md)  
  
- Copy the [!INCLUDE[pn_citrix](../includes/pn-citrix.md)] application executable and other required assemblies in the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] client installation directory, apply client-side registry patch, and add [!INCLUDE[pn_citrix](../includes/pn-citrix.md)]-specific settings in the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] client app config file. This step needs to be performed on each computer where the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] client application is installed.  
  
<a name="ConfRemoteHosted"></a>   
### Configure a Remote Hosted Application  
  
1. Sign in to Unified Service Desk Administrator.  
  
2. Select **Hosted Controls** under **Basic Settings**.
  
3. Select **+ New**.
  
4. Specify the following in the **General** tab of the **New Hosted Control** page.

   | Field | Value |
   |-------------------------|--------------------------------------------------------------|
   | Name | Citrix Application <br><br> Specify a name for the hosted control. Each hosted application should have a unique name. |
   | Sort |  5 <br> **Note:** This is an example value. <br><br> Sort order specifies the order in which the hosted applications are retrieved and displayed in Unified Service Desk. |
   | Unified Service Desk Component Type | CCA Hosted Application |
   | Hosted Application Type | Remote Hosted Application |
   | Application Global | Select the check box |
   | Display Group | MainPanel |
   | Adapter | Use No Adapter <br> <ul> <li>**Use No Adapter**: Specifies that the hosted application does not require any automation. </li><li> **Use Automation Adapter (HAT)**: Specifies the default configuration used for the Hosted Application Toolkit (HAT) Software Factory. If the hosted application uses an Automation Adapter (HAT), specify the hosted application’s binding information in the **Automation XML** field under the **Automation** area. For more information about bindings, see [Use UII inspector to create bindings for the hosted application](../unified-service-desk/use-uii-inspector-create-bindings-hosted-application.md). </li><li> **Use Adapter**: Specifies that the hosted application uses a custom adapter.</li> </ul> For information about using adapters for Citrix integration, see [Sample Citrix adapters](#sample-citrix-adapters)|
   | Application is Dynamics | Yes |
   | User Can Close | Select the check box |

5. Select the **Hosting** tab and specify the following.

   | Field | Value |
   |-------------------------|--------------------------------------------------------------|
   | Top Level Window Mode | None |
   | Assembly URI | `Microsoft.Uii.Csr.CitrixIntegration` |
   | Assembly Type | `Microsoft.Uii.Csr.CitrixIntegration.CitrixApplicationHostedControl` |
   | ICA File Name |`C:\Q29udHJvbGxlci5DYWxjdWxhdG9y.ica` <br> Specify the full path to the .ica file required for launching the [!INCLUDE[pn_citrix](../includes/pn-citrix.md)] application. An .ica file contains information to connect to the remote server  such as the server address, session properties, and authentication information. |
   | Process Acquisition Attempts | 5 <br> Specify the number of times the server-side executable file should scan the process table to look for the process running the launched Citrix application. The Citrix application process may take a little while to appear in the process table. |
   | Process Acquisition Delay | 5000 <br> Specify the delay in milliseconds between each process table scan. |
   | Process Acquisition FileName | Specify the complete path to the Citrix application file name. This value is used by the server-side executable file to compare against the file names of the running processes to find a match. |
  
6. Save the hosted control.

> [!Note]
> Citrix generates the ICA file on-the-go using the Citrix application portal. However, the out-of-the-box implementation in Unified Service Desk does not support on-the-go generated ICA file.
  
### Copy executable, apply registry patch, and add Citrix config settings  
 This step must be performed on each computer where the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] client application is installed.  
  
1. Navigate to the `<ExtractedFolder>\UII\Bin\UII\Citrix Server Component` folder where  \<ExtractedFolder> is the location where you extracted the downloaded the UII SDK package file in the  [Configure server-side component for Citrix integration](#ServerSide) section earlier.  
  
2. Copy the following files from the   `<ExtractedFolder>\UII\Bin\UII\Citrix Server Component` folder to the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] client folder (typically C:\Program Files\Microsoft Dynamics CRM USD\USD):  
  
   -   Microsoft.Uii.Csr.CitrixIntegration.exe  
  
   -   AxWFICALib.dll  
  
   -   WFICALib.dll  
  
3. Apply the registry patch on your [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] client computer to enable the use of custom virtual channels by running the following files available at `<ExtractedFolder>\UII\Bin\UII\Citrix Server Component` folder:  
  
   - **For x86 client**:  RegPatch Allow Custom Virtual Channels in ICAClient.reg  
  
   - **For x64 client**:  RegPatch Allow Custom Virtual Channels in ICAClient x64 Client.reg  
  
   > [!NOTE]
   >  If this registry patch is not applied, communication between client and server won't be possible.

4. Add the following app settings in the UnifiedServiceDesk.exe.config file available in the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] client installation directory. These app settings must be added under the root `<configuration>` node:

   ```xml
   <appSettings>
       <add key="CitrixIntegration.VirtualChannelNamePrefix" value="CTXUII"/>
       <add key="CitrixIntegration.XmitFragmentSize" value="200"/>
       <add key="CitrixIntegration.RecvTimeoutInMilliseconds" value="2000"/>
       <add key="CitrixIntegration.HeartbeatMaxWaitInMilliseconds" value="60000"/>
       <add key="CitrixIntegration.ClientOnly.HeartbeatIntervalInMilliseconds" value="15000"/>
   </appSettings>
   ```

   > [!NOTE]
   >  These app settings are also available in the server-side component in the Microsoft.Uii.Csr.CitrixIntegration.exe.config file.

    Here is a description of each key:

   |Key|Description|
   |---------|-----------------|
   |CitrixIntegration.VirtualChannelNamePrefix|For every launched Citrix application, two distinctly named virtual channels are created sharing a common prefix. This setting exposes the prefix to customization, though normally it will not be necessary. This setting must be identical both on the client-side and server-side.|
   |CitrixIntegration.XmitFragmentSize|Virtual channel transmissions are fragmented to the limit specified here. The key will be internally capped should it exceed internal limits (trace messaging should report when this happens.) This setting can differ between the client-side and server-side.|
   |CitrixIntegration.RecvTimeoutInMilliseconds|As with all network communication, timeouts are necessary to help decide when the communication peer is unavailable. Citrix integration communication is request/response oriented, and this setting specifies how long it takes to return the  response before the system abandons waiting for the response. This setting can differ between the client-side and server-side.|
   |CitrixIntegration.HeartbeatMaxWaitInMilliseconds|Any virtual channel communication activity is counted as a "heartbeat." This setting specifies the maximum amount of time that can elapse without any intervening communication, after which, either side of the communication channels (client or server) concludes that the opposing peer has become unavailable. For the server-side executable (Microsoft.Uii.Csr.CitrixIntegration.exe), it terminates after making this conclusion. For the client-side hosted control instance, it terminates the internal heartbeat ping timer. This setting can differ between the client-side and server-side.|
   |CitrixIntegration.ClientOnly.HeartbeatIntervalInMilliseconds|Specifies the period of a timer that triggers PING messages to the server-side executable (Microsoft.Uii.Csr.CitrixIntegration.exe), which in turn will reply with corresponding PONG messages. This is to prevent both the client and server components from incorrectly concluding their communication. This setting is only applicable for the client-side.|

<a name="IntegrationFlow"></a>
## Citrix integration: How does it work?
 Now that you know how to configure Citrix integration in Unified Service Desk, here is how the Citrix integration works right from when an agent starts the hosted control in the Unified Service Desk client to when the hosted control is closed.

1.  Customer service agent starts the Citrix hosted control from the Unified Service Desk client, which launches the Citrix application on the Citrix server using the ICA File Name configured for the hosted control.

2.  The server-side executable (Microsoft.Uii.Csr.CitrixIntegration.exe) starts automatically, and requests the Citrix application settings configured for the hosted control from the Unified Service Desk client. You configured this information in step 8 in section [Configure a Remote Hosted Application](#ConfRemoteHosted)

3.  If the application settings request times out based on the value specified in the `CitrixIntegration.RecvTimeoutInMilliseconds` app setting, the server-side executable (Microsoft.Uii.Csr.CitrixIntegration.exe) concludes that the Citrix application instance is not a UII hosted application, and terminates.

     If the application settings request does not time out, proceed to the next step.

4.  Using the application settings of the Citrix hosted control, the server-side executable (Microsoft.Uii.Csr.CitrixIntegration.exe) proceeds to identify the Citrix application process.

    -   If the Citrix application process could not be identified, the server-side executable remains running, and sends a message to the client about the same. You can view the message if you have turned on tracing.

    -   If the Citrix application process is identified,  the server-side executable acquires the process, and proceeds with identifying the designated top-window for the application. The  configuration commonly used for External Applications is referenced by the server-side executable and can be leveraged to select a non-default top-window. If the top-window could not be found, the server-side executable remains running, and sends an Info  message to the client that can be seen when tracing has been turned on.

5.  Finally, the application adapter for the hosted control is instantiated. The acquired process and top-window are provided to the adapter, and all adapter operations are routed between client and server at this point.

    > [!NOTE]
    >  If the process could not be found, the value will be null. If the window could not be found, the value will be 0. If the adapter could not be instantiated, the server-side executable remains running, and sends an Info message to the client that can be see when tracing has been turned on.

6.  When Customer service agent closes the Citrix hosted control in the Unified Service Desk client, the server-side executable is also terminated.

<a name="SampleAdapters"></a>
## Sample Citrix adapters
 Here are some sample Citrix adapters available for you to review/try.

### Sample Application Adapter
 A sample application adapter for Citrix is available in the UII SDK download package. To review/try this adapter:

1. [Download](https://go.microsoft.com/fwlink/p/?LinkId=519179) the [!INCLUDE[pn_user_inteface_integration_uii](../includes/pn-user-interface-integration-uii.md)] SDK package.

2. Double-click the package file to extract the contents.

3. Navigate to the `<ExtractedFolder>\UII\SampleCode\UII\Citrix\ApplicationAdapter` folder. The README.txt file in the folder provides information about this adapter.

### Sample Data-Driven Adapter
 To facilitate the use of existing Data-Driven adapters (DDAs) without requiring development of a custom Adapter, Unified Service Desk provides the following adapter to consume the DataDrivenAdapterBindings tag to instantiate the DDA, and to translate DDA Actions into calls on to the instantiated DDA: Microsoft.Uii.HostedApplicationToolkit.DataDrivenAdapter.dll. By default, this assembly is available  in your Unified Service Desk client installation directory.

 To use the sample DDA adapter with your Citrix hosted control, update the hosted control definition to specify the following values under the **Adapter Configuration** area for your hosted control:

|Field|Value|
|-----------|-----------|
|**Adapter**|Use Adapter|
|**URI**|Microsoft.Uii.HostedApplicationToolkit.DataDrivenAdapter|
|**Type**|Microsoft.Uii.HostedApplicationToolkit.DataDrivenAdapter.DdaAutomationAdapter|

<a name="BestPractices"></a>
## Citrix integration: Best practices
 Here are some things you might consider doing while setting up integration with Citrix applications.

- Ensure that the Citrix application that you want to host in Unified Service Desk can be successfully launched on its own by explicitly starting it.

- Use tracing to identify and troubleshoot issues. The trace messaging helps you identify and troubleshoot issues, if any. By default `Verbose` tracing is enabled in the Microsoft.Uii.Csr.CitrixIntegration.exe.config file to log the execution messages on the server:

  ```xml
  <add name="Microsoft.Uii.Common.Logging" value="Verbose"/>
  ```

   You can then use one of the standard [!INCLUDE[pn_user_inteface_integration_uii](../includes/pn-user-interface-integration-uii.md)] logging providers, for example, (the file logging provider, to write the trace logs to a file. The traces will also appear in any attached debuggers. The same settings on the client-side (UnifiedServiceDesk.exe.config file) will activate tracing on the client-side.

- In Windows, multiple processes running the same program share their memory pages that contain executable code. The nature of .NET programs is that the just-in-time (JIT) compiler compiles the intermediate language (IL) to machine instructions (executable code) at runtime when the application is launched. This runtime compiling prevents the sharing of otherwise identical code pages, which prevents the code page sharing optimization. Because the server-side executable (Microsoft.Uii.Csr.CitrixIntegration.exe) is a .NET program where multiple instances can be running on a single computer, it will be effective to leverage the [Ngen.exe (Native Image Generator)](/dotnet/framework/tools/ngen-exe-native-image-generator) tool to create native images of the dependent assemblies for the server-side executable, and install them into the native image cache on the local computer. This will facilitate better server resource utilization by using native images from the cache instead of using the JIT compiler to compile the original assembly.

### See also
 [UII hosted applications](../unified-service-desk/uii-hosted-applications.md)

 [Create and manage UII hosted applications](../unified-service-desk/create-manage-uii-hosted-applications.md)
 
 [Extend Unified Service Desk](../unified-service-desk/extend-unified-service-desk.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]