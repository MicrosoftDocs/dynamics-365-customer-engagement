---
title: "Show Bing Maps on forms in Dynamics 365 Customer Engagement (on-premises)"
description: "Learn how to enable Bing Maps to be displayed on a form, and configure properties such as labels and formatting."
ms.date: 06/16/2025
ms.reviewer: matp
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: f9729664-561c-4758-86ce-7216d68075d9
caps.latest.revision: 63
ms.author: fafuxa
author: fafuxa-ms
search.audienceType: 
  - customizer

---
# Configure Bing Maps to be displayed on forms

> [!IMPORTANT]
> The Bing Maps control uses the Bing Maps for Enterprise service. The Bing Maps for Enterprise service is deprecated and when used with a Free (Basic) account will be retired on June 30th, 2025. More information: [Bing Maps coverage](/bingmaps/coverage/)

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Configure a map on a form](/powerapps/maker/model-driven-apps/configure-bing-maps-legacy)

 Bing Maps can be displayed on a form for the account, contact, lead, quote, order, invoice, competitor, and system user entities. You can remove the Bing Maps area in the form editor or add it back by using the **Bing Maps** button on the **Insert** tab of the form editor.  

 To enable Bing Maps the system setting **Show Bing Maps on forms** must be enabled.  


|      Tab       |                        Property                         |                                                                                                  Description                                                                                                   |
|----------------|---------------------------------------------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|  **General**   |                        **Label**                        |                                                                              **Required**: A label to display for the Bing Maps.                                                                               |
|                |              **Display label on the form**              |                                                                                     Whether the label should be displayed.                                                                                     |
|                | **Select an address to use with the Bing Maps control** |                                                                        Choose which address should be used to provide data for the map.                                                                        |
|                |                 **Visible by default**                  | Showing the Bing maps is optional and can be controlled using business rules or scripts. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Visibility options](../customize/visibility-options-legacy.md) |
| **Formatting** |  **Select the number of columns the control occupies**  |                              When the section containing the Bing Maps has more than one column you can set the field to occupy up to the number of columns that the section has.                              |
|                |   **Select the number of rows the control occupies**    |                                                                  You can control the height of the Bing Maps by specifying a number of rows.                                                                   |
|                |     **Automatically expand to use available space**     |                                                                        You can allow the Bing Maps height to expand to available space.                                                                        |

## See also

[Use the Main form and its components](../customize/use-main-form-and-components.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
