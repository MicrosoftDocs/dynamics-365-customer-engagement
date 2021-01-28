---
title: Web resource properties for Main forms | MicrosoftDocs
description: Understand the Web resource properties for Main forms
Keywords: Main form; Web resource properties; Dynamics 365 for Customer Engagement
author: Mattp123
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - powerapps
ms.author: matp
manager: kvivek
ms.date: 04/26/2018
ms.service: crm-online
ms.topic: article
ms.assetid: 82cd41ea-95b0-4606-9e7d-43eb5ce9ecd6
search.audienceType: 
  - customizer
---
# Web resource properties

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Web resource properties for model-driven app forms](/powerapps/maker/model-driven-apps/web-resource-properties-legacy)

 You can add or edit web resources on a form to make it more appealing or useful to app users. Form enabled web resources are images, HTML files, or [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] controls.  

You can access **Form properties** by opening solution explorer. Under **Components**, expand **Entities**, expand the entity you want, and then select **Forms**. In the list of forms, open the form of type **Main**. Then on the **Insert** tab, select **Web Resource** to view web resource properties.

![web-resource-properties](media/web-resource-properties.png)

 For step-by-step instructions, see [Create and edit web resources](create-edit-web-resources.md).  


|       Tab        |                       Property                        |                                                                                                                                    Description                                                                                                                                    |
|------------------|-------------------------------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|   **General**    |                   **Web resource**                    |                                                                        **Required**: The image, HTML, or [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] web resource that you want.                                                                        |
|                  |                       **Name**                        |                                                                                   **Required**: A unique name for the field. The name can contain only alphanumeric characters and underscores.                                                                                   |
|                  |                       **Label**                       |                                                                                                              **Required**: A label to display for the web resource.                                                                                                               |
|                  |                **Visible by default**                 |                                 Showing the web resource is optional and can be controlled using scripts. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Visibility options](../customize/visibility-options-legacy.md)                                 |
|                  |                 **Enable for mobile**                 |                                                                                                               Select the checkbox to enable the iFrame for mobile.                                                                                                                |
|  **Formatting**  | **Select the number of columns the control occupies** |                                                              When the section containing the web resource has more than one column you can set the field to occupy up to the number of columns that the section has.                                                              |
|                  |  **Select the number of rows the control occupies**   |                                                                                                  You can control the height of the web resource by specifying a number of rows.                                                                                                   |
|                  |    **Automatically expand to use available space**    |                                                                                                        You can allow the web resource height to expand to available space.                                                                                                        |
|                  |     **Select the scrolling type for the IFRAME**      |          An HTML web resource is added to the form using an IFRAME.<br /><br /> - **As Necessary**: Show scrollbars when the size of the web resource is larger than the available.<br />- **Always**: Always show scrollbars.<br />- **Never**:  Never show scrollbars.          |
|                  |                  **Display border**                   |                                                                                                                     Display a border around the web resource.                                                                                                                     |
| **Dependencies** |                 **Dependent fields**                  | A web resource may interact with fields in the form using script. If a field is removed from the form the script in the web resource may break. Add any fields referenced by scripts in the web resource to the **Dependent fields** so that they cannot be removed accidentally. |

<a name="BKMK_PassingParametersToWebResource"></a>   
### Pass parameters to web resources  
 An HTML or [!INCLUDE[pn_Silverlight_short](../includes/pn-silverlight-short.md)] web resource can accept parameters to be passed as query string parameters.  

 Information about the record can be passed by enabling the **Pass record object-type code and unique identifiers as parameters** option. If information is typed into the **Custom Parameter(data)** field it will be passed using the data parameter. The values passed are:  

|Parameter|Description|  
|---------------|-----------------|  
|`data`|This parameter is only passed when text is provided for **Custom Parameter(data)**.|  
|`orglcid`|The Organization default language LCID.|  
|`orgname`|The name of the organization.|  
|`userlcid`|The user’s preferred language LCID|  
|`type`|The entity type code. This value can be different for custom entities in different organizations. Use entity type name instead.|  
|`typename`|The entity type name.|  
|`id`|The id value of the record. This parameter has no value until the entity record is saved.|  

 Any other parameters are not allowed and the web resource will not open if other parameters are used. If you need to pass multiple values, the data parameter can be overloaded to include more parameters within it.   

## See also

[Use the Main form and its components](../customize/use-main-form-and-components.md)
