---
title: "JavaDDA in Unified Service Desk | MicrosoftDocs"
description: "The Java data-driven adapter (JavaDDA) uses the Java Access Bridge to automate Java applications. User Interface Integration (UII) supports Java Access Bridge 2.0.2."
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
# JavaDDA in Unified Service Desk
The [!INCLUDE[pn_Java](../includes/pn-java.md)] data-driven adapter (JavaDDA) uses the [Java Access Bridge](https://www.oracle.com/technetwork/java/javase/tech/index-jsp-136191.html) to automate [!INCLUDE[pn_Java](../includes/pn-java.md)] applications. [!INCLUDE[pn_user_inteface_integration_uii](../includes/pn-user-interface-integration-uii.md)] supports Java Access Bridge 2.0.2. You can use tools such as [Java Monkey](https://docs.oracle.com/javase/accessbridge/2.0.2/javamonkey.htm) and [Java Ferret](https://docs.oracle.com/javase/accessbridge/2.0.2/javaferret.htm) to understand the accessibility structure of the application. To use the DDA, you need to inspect the application using either of these tools, and build the bindings manually and feed them to the DDA using initstring.  
  
 The JavaDDA defines three control types:  `JAccControl`, `JAccSelector`, and `JAccTree`. Each control tag must have a name attribute that specifies the name of the control used in [!INCLUDE[pn_hosted_application_toolkit_hat](../includes/pn-hosted-application-toolkit-hat.md)]automation activities.  
  
> [!NOTE]
> [!INCLUDE[pn_Java](../includes/pn-java.md)] Abstract Window Toolkit (AWT) applications are not fully supported in [!INCLUDE[pn_hosted_application_toolkit_hat](../includes/pn-hosted-application-toolkit-hat.md)]. You must configure the AWT applications with the WinDDA and run them as regular Win32 applications. The WinDDA uses Microsoft Active Accessibility (MSAA) to access the applications controls. Some AWT controls might not be fully compatible with MSAA, so they may not function properly. The JavaDDA is not supported for [!INCLUDE[pn_WinSer2008](../includes/pn-winser2008.md)]. To access [!INCLUDE[pn_Java](../includes/pn-java.md)] AWT controls, you can use tools such as [Java Monkey](https://docs.oracle.com/javase/accessbridge/2.0.2/javamonkey.htm) and [Java Ferret](https://docs.oracle.com/javase/accessbridge/2.0.2/javaferret.htm).  
  
## JavaDDA tags  
 The following are the various JavaDDA tags:  
  
-   [JAccControl Tag](../unified-service-desk/jacc-control-tag.md)  
  
-   [JAccSelector Tag](../unified-service-desk/jacc-selector-tag.md)  
  
-   [JAccTree Tag](../unified-service-desk/jacc-tree-tag.md)  
  
-   [Search Path Node Tag](../unified-service-desk/search-path-node-tag.md)  
  
-   [Next Tag](../unified-service-desk/next-tag-javadda.md)  
  
-   [NextRole Tag](../unified-service-desk/nextrole-tag.md) 
  
-   [FindWindow search path tag](../unified-service-desk/find-window-search-path-tag.md)  
  
-   [JavaDDA Events](../unified-service-desk/java-dda-events.md)  
  
### See also  
 [Use Data Driven Adapters](../unified-service-desk/use-data-driven-adapters-ddas.md)   
 [WinDDA](../unified-service-desk/windda.md)   
 [WebDDA](../unified-service-desk/web-dda.md)   
 [UIADDA](../unified-service-desk/uiadda.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]