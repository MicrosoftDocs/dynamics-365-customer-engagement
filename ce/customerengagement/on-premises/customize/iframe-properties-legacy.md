---
title: "Set iFrame properties in Dynamics 365 Customer Engagement (on-premises)"
description: "You can add iFrames to a form to integrate content from another website within the form. Learn how to manage properties such as name, formatting, and more."
Keywords: Main form; iFrame properties; Dynamics 365 for Customer Engagement
author: Mattp123
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - powerapps
ms.author: matp

ms.topic: article
ms.assetid: 1b7e6a0c-18a9-47e2-aa7d-0cffb8c93b19
search.audienceType: 
  - customizer

---
# Access and set the iFrame properties of a form

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [iFrame properties for model-driven app main forms](/powerapps/maker/model-driven-apps/iframe-properties-legacy)

You can add iFrames to a form to integrate content from another website within a form. 

You can access **Form properties** in solution explorer. Under **Components**, expand **Entities**, expand the entity you want, and then select **Forms**. In the list of forms, open the form of type **Main**. Then on the **Insert** tab, select IFRAME to view IFRAME properties.

![Add an iframe properties page.](media/iframe-properties.png)

> [!NOTE]
> Forms are not designed to be displayed within an iFrame.  
  
|       Tab        |                               Property                                |                                                                                                                            Description                                                                                                                            |
|------------------|-----------------------------------------------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|   **General**    |                               **Name**                                |                                                                          **Required**: A unique name for the iFrame. The name can contain only alphanumeric characters and underscores.                                                                           |
|                  |                                **URL**                                |                                                                                                   **Required**: The URL for the page to display in the iFrame.                                                                                                    |
|                  | **Pass record object-type code and unique identifiers as parameters** |    Data about the organization, user, and the record can be passed to the iFrame. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Pass parameters to iFrames](#pass-parameters-to-iframes)     |
|                  |                               **Label**                               |                                                                                                         **Required**: A label to display for the iFrame.                                                                                                          |
|                  |                     **Display label on the Form**                     |                                                                                                              Whether the label should be displayed.                                                                                                               |
|                  |          **Restrict cross-frame scripting, where supported**          |           It is considered a security risk to allow pages from a different web site to interact with the Dynamics 365 for Customer Engagement application using scripts. Use this option to restrict cross frame scripting for pages you do not have control over.<br /><br />            |
|                  |                        **Visible by default**                         |                            Showing the iFrame is optional and can be controlled using scripts. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Visibility options](../customize/visibility-options-legacy.md)                            |
|                  |                         **Enable for mobile**                         |                                                                                                       Select the checkbox to enable the iFrame for mobile.                                                                                                        |
|  **Formatting**  |         **Select the number of columns the control occupies**         |                                                         When the section containing the iFrame has more than one column you can set the field to occupy up to the number of columns that the section has.                                                         |
|                  |          **Select the number of rows the control occupies**           |                                                                                   You can control the height of the iFrame by specifying a number of rows the control occupies.                                                                                   |
|                  |            **Automatically expand to use available space**            |                                                                         Instead of setting the height by a number of rows, you can allow the iFrame height to expand to available space.                                                                          |
|                  |             **Select the scrolling type for the iFrame**              |                   You have three options:<br /><br /> - **As Necessary**: Show scrollbars when the size of the iFrame is larger than the available space.<br />- **Always**: Always show scrollbars.<br />- **Never**:  Never show scrollbars.                    |
|                  |                          **Display border**                           |                                                                                                                Display a border around the iFrame.                                                                                                                |
| **Dependencies** |                         **Dependent fields**                          | An iFrame may interact with fields in the form using script. If a field is removed from the form the script in the iFrame may break. Add any fields referenced by scripts in the iFrames to the **Dependent fields** so that they cannot be removed accidentally. |
  
## Pass parameters to iFrames  
 Information about the record can be passed by enabling the **Pass record object-type code and unique identifiers as parameters** option. The values passed are:  
  
|Parameter|Description|  
|---------------|-----------------|  
|`orglcid`|The Organization default language LCID.|  
|`orgname`|The name of the organization.|  
|`userlcid`|The user’s preferred language LCID|  
|`type`|The entity type code. This value can be different for custom entities in different organizations. Use `typename` instead.|  
|`typename`|The entity type name.|  
|`id`|The id value of the record. this parameter has no value until the entity record is saved.|  

## See also

[Use the Main form and its components](../customize/use-main-form-and-components.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
