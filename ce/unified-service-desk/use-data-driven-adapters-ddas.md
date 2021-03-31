---
title: "Use data driven adapters (DDAs) in Unified Service Desk | MicrosoftDocs"
description: "Learn how to use data-driven adapters (DDAs) in Unified Service Desk."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/23/2017
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
# Use data driven adapters (DDAs) in Unified Service Desk
Data-driven adapters (DDAs) are the adapters leveraged generally by the [!INCLUDE[pn_hosted_application_toolkit_hat](../includes/pn-hosted-application-toolkit-hat.md)]. These adapters are generic assemblies that handle only the interaction with the UI and do not contain business processes. The [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] SDK ships with a DDA that provides a common set of functions that allows you to host and access a wide range of applications. However, you might require additional functionality depending on the type of application. There are various ways of extending the existing functionality, such as creating a new DDA (and using it in a composite DDA with outer DDAs) and extending an existing DDA.  
  
## In This Section  
 [Types of Data Driven Adapters](../unified-service-desk/use-data-driven-adapters-ddas.md#types)  
  
 [Creating a DDA](../unified-service-desk/use-data-driven-adapters-ddas.md#create)  
  
 [Extending an existing DDA](../unified-service-desk/use-data-driven-adapters-ddas.md#extend)  
  
 [Bindings](../unified-service-desk/use-data-driven-adapters-ddas.md#bindings)  
  
 [Using DDAs in custom application adapters](../unified-service-desk/use-data-driven-adapters-ddas.md#custom)  
  
<a name="types"></a>   
## Types of Data Driven Adapters  
 There are four types of DDAs:  
  
-   [WinDDA](../unified-service-desk/windda.md)  
  
-   [WebDDA](../unified-service-desk/web-dda.md)  
  
-   [UIADDA](../unified-service-desk/uiadda.md)  
  
-   [JavaDDA](../unified-service-desk/javadda.md)  
  
<a name="create"></a>   
## Creating a DDA  
 You can create a new DDA by simply inheriting the [DataDrivenAdapterBase](https://docs.microsoft.com/dotnet/api/microsoft.uii.hostedapplicationtoolkit.datadrivenadapter.datadrivenadapterbase) class.  
  
 The class has the constructor which can be overloaded.  
  
<a name="extend"></a>   
## Extending an existing DDA  
 In the previous section we saw how to create a DDA. However, if your customization is nominal, you can use the existing DDA and extend it as per requirements.  
  
 You can use the following classes to extend the existing UII DDAs:  
  
- [WinDataDrivenAdapter](https://docs.microsoft.com/dotnet/api/microsoft.uii.hostedapplicationtoolkit.datadrivenadapter.windatadrivenadapter): Creates an adapter based on the WinDDA.  
  
- [WebDataDrivenAdapter](https://docs.microsoft.com/dotnet/api/microsoft.uii.hostedapplicationtoolkit.datadrivenadapter.webdatadrivenadapter): Creates an adapter based on the WebDDA.  
  
- [JavaDataDrivenAdapter](https://docs.microsoft.com/dotnet/api/microsoft.uii.hostedapplicationtoolkit.datadrivenadapter.javadatadrivenadapter): Creates an adapter based on the JavaDDA.  
  
- [UIADataDrivenAdapter](https://docs.microsoft.com/dotnet/api/microsoft.uii.hostedapplicationtoolkit.datadrivenadapter.uiadatadrivenadapter): Creates an adapter based on the UIADDA.  
  
  All the preceding classes derive from [DataDrivenAdapterBase](https://docs.microsoft.com/dotnet/api/microsoft.uii.hostedapplicationtoolkit.datadrivenadapter.datadrivenadapterbase) class.  
  
<a name="bindings"></a>   
## Bindings  
 A data-driven adapter uses data, named the bindings, to define the way that it identifies a UI component of a hosted application. For example, the bindings may consist of Document Object Model (DOM) paths for describing elements on a webpage. The following example shows an application initialization string with an embedded DDA binding sub-tree. This is a general example, but it indicates the pattern used to implement `Acc` controls in Windows bindings.  
  
> [!NOTE]
>  Some of the configuration parameters have been removed for clarity.  
  
```xml  
<initstring>  
    <interopAssembly>  
      <URL>path to executable</URL>  
      <Arguments>test argument</Arguments>  
      <WorkingDirectory>c:\</WorkingDirectory>  
      <hostInside/>  
    </interopAssembly>  
<!—- notice there is no custom application adapter specified here-->  
    <displayGroup>None</displayGroup>  
    <optimumSize x="800" y="600"/>  
    <minimumSize x="640" y="480"/>  
    <DataDrivenAdapterBindings>  
      <Type>typeName, assemblyName</Type>  
      <Controls>  
        <AccControl name="combobox1">  
          <Path>  
            <FindWindow>  
              <ControlID>1003</ControlID>  
            </FindWindow>  
          </Path>  
        </AccControl>  
</Controls>  
    </DataDrivenAdapterBindings>  
</initstring>  
  
```  
  
 If you are using the HAT Software Factory, it will create the `InitString`. The application can then be deployed to the server from the software factory.  
  
 If you are directly adding a hosted application using the Admin UI, you do not need to create the complete `InitString`. You only need to specify the <`DataDrivenAdapterBindings`> section and add it to the `Automation Xml` tab.  
  
<a name="custom"></a>   
## Using DDAs in custom application adapters  
 Although DDAs were initially conceived to support automations within the [!INCLUDE[pn_hosted_application_toolkit_hat](../includes/pn-hosted-application-toolkit-hat.md)], they can also be used by custom adapters to achieve useful results. The following code sample, taken from a custom adapter, illustrates how custom adapters can use DDAs, and illustrates the general advantages of DDAs. As the sample illustrates, the use of DDAs allows a separation of code and configuration information.  
  
```csharp  
DataDrivenAdapter Dda;  
public overrIDe bool Initialize()  
{  
   Dda=DataDrivenAdapter.CreateInstance(ApplicationInitString,ApplicationObject);  
   return (Dda != null);  
}  
public overrIDe bool DoAction(Action action, ref string data)  
{  
if (action.Name == "AddToHistory")  
   {  
   Dda.ExecuteControlAction("combobox1");  
   Dda.SetControlValue("textbox1", data);  
   Dda.ExecuteControlAction("button1");  
   }  
}  
  
```  
  
 The DDA configuration, which is embedded in the application's `InitString`, is XML, as in the following example.  
  
```xml  
<DataDrivenAdapterBindings>  
<Type> Microsoft.UII.HostedApplicationToolkit.DataDrivenAdapter.WinDataDrivenAdapter, Microsoft.UII.HostedApplicationToolkit.DataDrivenAdapter</Type>  
  <Controls>  
    <AccControl name="combobox1">  
      <Path>  
        <FindWindow>  
          <ControlID>1003</ControlID>  
        </FindWindow>  
      </Path>  
    </AccControl>  
    <AccControl name="textbox1">  
      <Path>  
        <FindWindow>  
          <ControlID>1001</ControlID>  
        </FindWindow>  
      </Path>  
    </AccControl>  
    <AccControl name="button1">  
      <Path>  
        <FindWindow>  
          <ControlID>1002</ControlID>  
        </FindWindow>  
      </Path>  
    </AccControl>  
  </Controls>  
</DataDrivenAdapterBindings>  
  
```  
  
 The `<Type/>` element directs UII to dynamically instantiate the type specified in type, assembly format, thus allowing custom DDAs to be loaded and used. The `<Controls/>` element contains the list of configured controls, specified in a manner required by the loaded DDA.  
  
### See also  
 [Work with HAT Software Factory](../unified-service-desk/work-with-hat-software-factory.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]