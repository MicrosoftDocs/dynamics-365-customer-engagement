---
title: "Understand dashboards: Dashboard components and FormXML (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Dashboards are one of the different types of forms in Dynamics 365 Customer Engagement. You can use the SystemForm.Type or UserForm.Type attribute to determine whether the form is a dashboard."
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 4676c26b-8f5b-4497-b552-056e74ab2a07
caps.latest.revision: 49
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Understand dashboards: Dashboard components and FormXML

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Dashboards are one of the different types of forms in [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] Customer Engagement. You can use the `SystemForm.Type` or `UserForm.Type` attribute to determine whether the form is a dashboard. A form of dashboard type has the property value of ”0”.  

 The definition of the form content and presentation is stored in the FormXML. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Form XML Schema](form-xml-schema.md)  

 For sample FormXML strings for different types of dashboards, see [Sample Dashboards](sample-dashboards.md).  

<a name="DashboardComponents"></a>   
## Dashboard components  
 A dashboard can contain charts, grids, IFRAMEs, or web resources. By default, a single dashboard can contain up to six of these components.  

 In the [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] on-premises version, you can change the number of components to be displayed on a dashboard using [!INCLUDE[pn_PowerShell](../../includes/pn-powershell.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Set the Number of Dashboard Controls](understand-dashboards-dashboard-components-formxml.md#set_controls_limit)  

[!INCLUDE[cc_sdk_onpremises_note](../../includes/cc-sdk-onpremises-note.md)]
### Charts  
 An organization-owned dashboard can contain only organization-owned charts. However, a user-owned dashboard can contain user-owned and organization-owned charts. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Charts (Visualizations) for Microsoft Dynamics 365](view-data-with-visualizations-charts.md)  

### Grids  
 Grids fetch data from queries (views) in [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)]. An organization-owned dashboard can contain only the grids that fetch data from saved queries. However, a user-owned dashboard can contain grids that fetch data from user and saved queries. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)][SavedQuery Entity](../entities/savedquery.md)  

### IFRAMEs  
 When you add an IFRAME to an organization-owned dashboard, you can specify whether to restrict or allow cross-frame scripting. 
 To do so, you have to use the `<Security>` parameter in the IFRAME control in the FormXML. However, for user-owned dashboards, cross-frame scripting for IFRAMEs is restricted, and you can’t change it. If you attempt to create a user-owned dashboard that contains an IFRAME with cross-frame scripting enabled, an error message will be displayed.  

### Web resources  
 Only form-enabled web resources can be included in a dashboard. Although this restriction is applicable when you are adding a web resource using the Dashboard designer in the web application, there is no such restriction applied when adding a web resource to a dashboard using the SDK. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Web Resources for Microsoft Dynamics 365](../web-resources.md)  

<a name="DashboardComponentsandFormXML"></a>   
## Dashboard components and FormXML elements  
 The dashboard components are displayed in [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] based on the values specified in the FormXML. The following image shows an example of a dashboard. Each dashboard can include multiple tabs. Tabs are a vertical stack separating the body of the dashboard, and can be expanded or collapsed. A tab can contain multiple sections. Sections enable for grouping and layout of dashboard components. 

 ![Dashboard components layout](../media/crm-v5s-dashboards-components.png "Dashboard components layout")  

<a name="SupportedFormXMLElements"></a>   
## FormXML elements supported for dashboards  
 Although dashboards are a type of forms, not all FormXML elements and attributes are supported by dashboards. The following table provides information about the FormXML elements, child elements, and attributes supported by dashboards.

 For sample FormXML for different types of dashboards, see [Sample Dashboards](sample-dashboards.md).  


|    Element     |                                                                                                                                                                                                                          Child Elements                                                                                                                                                                                                                          |                                          Element attributes                                          |
|----------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|------------------------------------------------------------------------------------------------------|
|    `<form>`    |                                                                                                                                                                                                                             `<tabs>`                                                                                                                                                                                                                             |                                                  -                                                   |
|    `<tabs>`    |                                                                                                                                                                                                                             `<tab>`                                                                                                                                                                                                                              |                                                  -                                                   |
|    `<tab>`     |                                                                                                                                                                                                               -   `<labels>`<br />-   `<columns>`                                                                                                                                                                                                                | -   id<br />-   name<br />-   expanded<br />-   verticallayout<br />-   showlabel<br />-   locklevel |
|   `<labels>`   |                                                                                                                                                                                                                            `<label>`                                                                                                                                                                                                                             |                                                  -                                                   |
|   `<label>`    |                                                                                                                                                                                                                                -                                                                                                                                                                                                                                 |                                -   description<br />-   languagecode                                 |
|  `<columns>`   |                                                                                                                                                                                                                            `<column>`                                                                                                                                                                                                                            |                                                  -                                                   |
|   `<column>`   |                                                                                                                                                                                                                           `<sections>`                                                                                                                                                                                                                           |                                                width                                                 |
|  `<sections>`  |                                                                                                                                                                                                                           `<section>`                                                                                                                                                                                                                            |                                               addedby                                                |
|  `<section>`   |                                                                                                                                                                                                                 -   `<labels>`<br />-   `<rows>`                                                                                                                                                                                                                 |              -   id<br />-   name<br />-   showlabel<br />-   showbar<br />-   columns               |
|    `<rows>`    |                                                                                                                                                                                                                             `<row>`                                                                                                                                                                                                                              |                                               addedby                                                |
|    `<row>`     |                                                                                                                                                                                                                             `<cell>`                                                                                                                                                                                                                             |                                               addedby                                                |
|    `<cell>`    |                                                                                                                                                                                                               -   `<labels>`<br />-   `<control>`                                                                                                                                                                                                                |      -   auto<br />-   addedby<br />-   id<br />-   showlabel<br />-   rowspan<br />-   colspan      |
|  `<control>`   |                                                                                                                                                                                                                          `<parameters>`                                                                                                                                                                                                                          |                                       -   id<br />-   classid                                        |
| `<parameters>` | -   `<Url>`<br />-  `<PassParameters>`<br />-   `<Security>`<br />-   `<Scrolling>`<br />-   `<Border>`<br />-   `<ViewIds>`<br />-   `<ViewId>`<br />-   `<IsUserView>`<br />-   `<IsUserChart>`<br />-   `<TargetEntityType>`<br />-   `<AutoExpand>`<br />-   `<RecordsPerPage>`<br />-   `<EnableQuickFind>`<br />-   `<EnableJumpBar>`<br />-   `<EnableChartPicker>`<br />-   `<EnableViewPicker>`<br />-   `<ChartGridMode>`<br />-   `<VisualizationId>` |                                                  -                                                   |

<a name="set_controls_limit"></a>   
## Set the number of dashboard controls  
 You can use [!INCLUDE[pn_PowerShell](../../includes/pn-powershell.md)] to adjust the number of dashboard controls as described here. The maximum value is 20.  

#### To retrieve and set the dashboard limit  

1. Open a [!INCLUDE[pn_PowerShell](../../includes/pn-powershell.md)] command window.  

2. Add the [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)][!INCLUDE[pn_PowerShell](../../includes/pn-powershell.md)] snap-in:  

   ```powershell  
   Add-PSSnapin Microsoft.Crm.PowerShell  
   ```  

3. Retrieve the current setting:  

   ```powershell  
   $setting = Get-CrmSetting -SettingType DashboardSettings  
   ```  

4. Modify the current setting:  

   ```powershell  
   $setting.MaximumControlsLimit = 5  
   ```  

   ```powershell  
   Set-CrmSetting -Setting $setting  
   ```  

### See also  
 [Dashboards for Microsoft Dynamics 365](analyze-data-with-dashboards.md)   
 [Actions on Dashboards](actions-dashboards.md)   
 [Create a Dashboard](create-dashboard.md)   
