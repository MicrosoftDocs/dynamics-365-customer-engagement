---
title: "Access external web resources (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Learn how to access a web resource, for example a web service, from a custom plug-in or workflow activity."
ms.custom: on-premise
ms.date: 2/6/2019
ms.reviewer: pehecke
ms.service: crm-online
ms.topic: "article"
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
author: "phecke"
ms.author: "pehecke"
manager: "kvivek"
search.audienceType: 
  - developer

---
# Access external web resources

Plug-ins and custom workflow activities executing in the sandbox can access the network through the HTTP and HTTPS protocols. This capability provides support for accessing popular web resources like social sites, news feeds, web services, and more. The following web access restrictions apply to this sandbox capability.

For more information, see the Dataverse topic [Access external web resources](/powerapps/developer/common-data-service/access-web-services).

For sandboxed plug-ins to be able to access external Web services from an on-premise D365 server, the server's Sandbox Processing Service role must be exposed to the Internet, and the account that the sandbox service runs under must have Internet access. Only outbound connections on ports 80 and 443 are required. Inbound connection access is not required. Use the Windows Firewall control panel to enable outbound connections for the Microsoft.Crm.Sandbox.WorkerProcess application located on the server in the %PROGRAMFILES%\Dynamics 365 Customer Engagement\Server\bin folder. Web access is supported by default for sandboxed plug-ins executing under Dataverse in the cloud.

## See also

[On-premise plug-in development](plugin-development.md)  
[Sample: Web Access from a plug-in](/powerapps/developer/common-data-service/org-service/samples/web-access-plugin)

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]