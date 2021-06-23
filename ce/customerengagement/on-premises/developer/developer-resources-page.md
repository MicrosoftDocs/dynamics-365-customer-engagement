---
title: "Developer resources page (Developer Guide for Dynamics 365 Customer Engagement (on-premises))| MicrosoftDocs"
description: "Read how you can find your organization unique name, Discovery service endpoint address, Organization service endpoint address and issuer name to access Azure Service Bus using the Developer Resources page"
ms.custom: 
ms.date: 03/29/2019
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 826ddda1-2038-40ba-a5a9-8b443a7a6b02
caps.latest.revision: 61
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Developer resources page 

The Developer Resources page in the [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] web application provides important resources. Included on this page are the web service endpoint URLs, a certificate for accessing [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)], and other organization information that you'll need during development. To access the page in the web application, click **Settings** > **Customizations**, and then click **Developer Resources**.  
  
 For the Organization service and Organization data service sections in this topic, the example URLs include an `OrganizationName`. This refers to the organization that you specify in the URL when you access the web application. For example, for Contoso.crm.dynamics.com, the `OrganizationName` is Contoso.  `ServerName` refers to the name of the server, including the port number, for example, myserver or myserver:5555.  
  
[!INCLUDE[cc_sdk_onpremises_note](../includes/cc-sdk-onpremises-note.md)]

<a name="org_unique"></a>   

## Organization unique name  

 Shows the unique name for your organization, which is needed when interacting with the discovery service. Note that this may not be the same as the name that’s specified in the URL. This name can be found in the following properties:  
  
- Deployment web service: <xref:Microsoft.Xrm.Sdk.Deployment.Organization.UniqueName>  
  
- Discovery web service: <xref:Microsoft.Xrm.Sdk.Discovery.OrganizationDetail.UniqueName>  
  
- Organization web service using early bound classes: `Organization.UniqueName`  
  
  You can also retrieve this from the discovery service by using the <xref:Microsoft.Xrm.Sdk.Discovery.RetrieveOrganizationsRequest> message.  
  
<a name="Windows_Azure"></a>   

## Microsoft Azure Service Bus issuer certificate  

 Provides a download link to the public certificate that is required to configure [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] for Dynamics 365 Customer Engagement (on-premises) integration. For an on-premises or Internet-facing deployment, this information is only visible after [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] has been configured for [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)] integration.  
  
 For more information, see [Azure Extensions for Dynamics 365 Customer Engagement (on-premises)](azure-extensions.md).  
 
  
<a name="discovery"></a>   

## Discovery service  

 The Discovery Service web service provides information about the organizations available on the Dynamics 365 Server. This information includes the web address (URL) for each organization.

  
### For [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]

You should generally use the global discovery service because this will ignore regional groupings and allow you to retrieve available organizations world-wide. See [Discover the URL for your organization using the Web API](webapi/discover-url-organization-web-api.md)


 If you want to scope the organizations to retrieve to individual regions use the following URLs to access the discovery service (use the appropriate URL for your location).  
  
[!INCLUDE [regional-discovery-services](../includes/regional-discovery-services.md)]
  
### For on-premises Dynamics 365 Customer Engagement (on-premises)
 Use the following URL to access the discovery service:  
  
 https://`ServerName`/XRMServices/2011/Discovery.svc  

For more information, see [Discover the URL for your organization using the Organization Service](org-service/discover-url-organization-organization-service.md).
  
<a name="OrganizationService"></a>   

## Organization service  

 The organization service provides access to the business data and metadata of your organization by using the SOAP protocol. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use the Organization Service to read and write data or metadata](org-service/use-organization-service-read-write-data-metadata.md).  
  
### For [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] 

 Use the following URLs to access the organization service (SOAP endpoint):  

|Region| URL|
|---|---|
|North America|`https://OrganizationName.api.crm.dynamics.com/XrmServices/2011/Organization.svc`|
|North America 2|`https://OrganizationName.api.crm9.dynamics.com/XrmServices/2011/Organization.svc`|
|South America|`https://OrganizationName.api.crm2.dynamics.com/XrmServices/2011/Organization.svc`|
|Canada|`https://OrganizationName.api.crm3.dynamics.com/XrmServices/2011/Organization.svc`|
|EMEA|`https://OrganizationName.api.crm4.dynamics.com/XrmServices/2011/Organization.svc`|
|APAC|`https://OrganizationName.api.crm5.dynamics.com/XrmServices/2011/Organization.svc`|
|Oceania|`https://OrganizationName.api.crm6.dynamics.com/XrmServices/2011/Organization.svc`|
|Japan|`https://OrganizationName.api.crm7.dynamics.com/XrmServices/2011/Organization.svc`|
|India|`https://OrganizationName.api.crm8.dynamics.com/XrmServices/2011/Organization.svc`|
|France|`https://OrganizationName.api.crm12.dynamics.com/XrmServices/2011/Organization.svc`|
  
### For on-premises Dynamics 365 Customer Engagement (on-premises)

 Use the following URL to access the organization service (SOAP endpoint):  
  
 `http[s]://ServerName/OrganizationName/XRMServices/2011/Organization.svc`  
  
<a name="OrganizationDataService"></a>   

## Organization data service  

 This Open Data (OData v2) Web service provides access to the business data of your organization by exposing a RESTAPI. This link opens the Conceptual Schema Definition Language (CSDL) document that describes how to access your data by using this API.  
  
> [!WARNING]
>  The Organization Data service has been deprecated and replaced by the Web API. For more information about the Web API see [Use the Dynamics 365 Customer Engagement Web API](use-microsoft-dynamics-365-web-api.md).  
  
### For [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]  

 Use the following URLs to access the organization data service (ODataREST endpoint):  

|Region| URL|
|---|---|
|North America|`https://OrganizationName.api.crm.dynamics.com/XrmServices/2011/OrganizationData.svc`|
|North America 2|`https://OrganizationName.api.crm9.dynamics.com/XrmServices/2011/OrganizationData.svc`|
|South America|`https://OrganizationName.api.crm2.dynamics.com/XrmServices/2011/OrganizationData.svc`|
|Canada|`https://OrganizationName.api.crm3.dynamics.com/XrmServices/2011/OrganizationData.svc`|
|EMEA|`https://OrganizationName.api.crm4.dynamics.com/XrmServices/2011/OrganizationData.svc`|
|APAC|`https://OrganizationName.api.crm5.dynamics.com/XrmServices/2011/OrganizationData.svc`|
|Oceania|`https://OrganizationName.api.crm6.dynamics.com/XrmServices/2011/OrganizationData.svc`|
|Japan|`https://OrganizationName.api.crm7.dynamics.com/XrmServices/2011/OrganizationData.svc`|
|India|`https://OrganizationName.api.crm8.dynamics.com/XrmServices/2011/OrganizationData.svc`|
|France|`https://OrganizationName.api.crm12.dynamics.com/XrmServices/2011/OrganizationData.svc`|
  
### For on-premises Dynamics 365 Customer Engagement (on-premises)  
 Use the following URL to access the organization data service (ODataREST endpoint):  
  
 `http[s]://ServerName/OrganizationName/XRMServices/2011/OrganizationData.svc`  
  
<a name="wsdl"></a>

## Using the WSDL

 To add a service reference for these services to a [!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)] project, you must append `?WSDL` to the service URL when specifying the address in the **Add Service Reference** dialog box. For example, the discovery service Web Services Description Language (WSDL) address is `http[s]://servername/xrmservices/2011/discovery.svc?wsdl`.  
  
 The web services support SDK versioning. Specifying an SDK version in the WSDL URL indicates a scope for the amount of data to be returned in the WSDL. The syntax for web service SDK versioning ends the URL in `?singleWSDL&sdkversion=X.X`. For example, the URL would be `https://mydomain.crm.dynamics.com/xrmservices/2011/discovery.svc?singleWSDL&sdkversion=8.0`. In this example, you would have built your application using the v8.0 .NET assemblies.  
  
### See also

 [Write Code for Dynamics 365 Customer Engagement Web Services](extend-dynamics-365-server.md)   
 [Use the IOrganizationService web service to read and write data or metadata](org-service/use-organization-service-read-write-data-metadata.md)   


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]