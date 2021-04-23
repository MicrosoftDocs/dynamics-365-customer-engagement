---
title: "Use UII adapters to interact with external and web applications in Unified Service Desk | MicrosoftDocs"
description: "Learn how to use UII adapters to interact with your external and web applications without having access to the application’s source code in Unified Service Desk."
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
# Use UII adapters to interact with external and web applications in Unified Service Desk
You can use [!INCLUDE[pn_user_inteface_integration_uii](../includes/pn-user-interface-integration-uii.md)] adapters to interact with your external and web applications without having access to the application’s source code.  
  
<a name="AppAdapter"></a>   
## Use the UII application adapter  
 External applications are executable (.exe) files that weren’t written specifically for [!INCLUDE[pn_user_inteface_integration_uii](../includes/pn-user-interface-integration-uii.md)]. External applications have their own processes. Typically, they’re written using Win32 APIs, Microsoft Foundation Classes (MFC), or Visual Basic 6.0. A UII application adapter ([HostedApplicationAdapter](/dotnet/api/microsoft.uii.csr.hostedapplicationadapter)) allows you to modify the behavior of the application without access to its source code.  
  
 [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] provides you a [!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)] project template for creating a [!INCLUDE[pn_user_inteface_integration_uii](../includes/pn-user-interface-integration-uii.md)] application adapter that contains pre-wired events and methods that you should implement to create your application adapter. For information about how you can create a UII application adapter to integrate with an external application, see [Walkthrough: Create a UII Application Adapter](../unified-service-desk/walkthrough-create-uii-application-adapter.md).  
  
<a name="WebAppAdapter"></a>   
## Use the UII web application adapter  
 You can host any browser-based site, webpage, or web application in **Unified Service Desk**. A UII web application adapter ([WebApplicationAdapter](/dotnet/api/microsoft.uii.csr.webapplicationadapter)) acts as an interface between the hosted web application and **Unified Service Desk**, allowing you to modify the behavior of the application without accessing its source code.  
  
 [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] provides you a [!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)] project template for creating a UII web application adapter that contains pre-wired events and methods that you should implement to create your web application adapter. For information about how you can create a UII web application adapter to integrate with an external application, see [Walkthrough: Create a UII Application Adapter](../unified-service-desk/walkthrough-create-uii-application-adapter.md).  
  
### UII action protocols  
 Under most conditions, [!INCLUDE[pn_user_inteface_integration_uii](../includes/pn-user-interface-integration-uii.md)] hosted applications aren’t modified to work with the agent desktop. Occasionally, though, application modifications are the most expedient way to handle required automations. If the situation allows, a webpage can leverage HTTP-oriented UII protocols to make calls into Application Integration Framework (AIF).In a hosted application, you can customize the webpage content by implementing additional action protocols. The following table describes the action protocols [!INCLUDE[pn_user_inteface_integration_uii](../includes/pn-user-interface-integration-uii.md)] provides.  
  
|Protocol|Requested URL|Description|  
|--------------|-------------------|-----------------|  
|UII|UII://\<Target App>/Action?\<ActionData>\<ActionData>|The protocol triggers a `RequestAction` event to the target web application.|  
|UIICTX|UIICTX://update/Name1=Value1&Name2=Value2|The protocol adds a name-value pair to the current context and triggers a **ChangeContext** event.|  
  
 The following is an example of a UII protocol call from an HTML page.  
  
```  
<HTML>  
  <HEAD>  
    <TITLE>Sample UII Protocol Call</TITLE>  
  </HEAD>  
  <BODY  
    <A href="UII://MyApp/MyAction?<GetFocus>true</GetFocus>">Click to execute an action</A></FONT></P>  
  </BODY>  
</HTML>  
  
```  
  
 In the preceding example, clicking the link initiates the `WebApplicationAdapter` for the `MyApp` web application and adapter. The adapter calls the action specified [!INCLUDE[pn_user_inteface_integration_uii](../includes/pn-user-interface-integration-uii.md)] protocol to update the [!INCLUDE[pn_user_inteface_integration_uii](../includes/pn-user-interface-integration-uii.md)] context. You can replace the [!INCLUDE[pn_user_inteface_integration_uii](../includes/pn-user-interface-integration-uii.md)] protocol with the UIICTX protocol to execute context update action.  
  
### See also  
 [Use HAT adapters](../unified-service-desk/use-uii-automation-adapter-interact-external-web-applications.md)   
 [UII adapters](../unified-service-desk/uii-adapters.md)   
 [Walkthrough: Create a UII Application Adapter](../unified-service-desk/walkthrough-create-uii-application-adapter.md)   
 [Walkthrough: Create a UII Web Application Adapter](../unified-service-desk/walkthrough-create-uii-web-application-adapter.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]