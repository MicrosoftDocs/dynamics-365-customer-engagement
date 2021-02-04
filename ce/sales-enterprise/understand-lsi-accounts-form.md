---
title: "Understand the LinkedIn Sales Insight tab in accounts forms (Dynamics 365 Sales) | MicrosoftDocs"
description: "Understand the LinkedIn Sales Insight tab in accounts forms in Dynamics 365 Sales."
ms.date: 02/11/2020
ms.service: "dynamics-365-sales"
ms.custom: "dyn365-sales"
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Understand the LinkedIn Sales Insights tab

> [!IMPORTANT]
> - The enhanced experience for LinkedIn Sales Insights solution is a preview feature. [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
> - [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
> - [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]

The **LinkedIn Sales Insights** tab in the **Account** records provides information about the company and personas that are defined for the company within LinkedIn Sales Insights product. When the solution is installed, two new entities are created in Dynamics 365 Sales.   
-	LinkedIn Sales Insights Company Profile (One Company profile record related to each Account).    
-	LinkedIn Sales Insights Personas (Three Personas records related to each Account).   

> [!div class="mx-imgBorder"]
> ![LinkedIn Sales Insights tab in accounts form](media/lsi-tab-account.png "LinkedIn Sales Insights tab in accounts form")

When CRM sync for LinkedIn Sales Insights is established, LinkedIn Sales Insights for Dynamics 365 brings data from all matched accounts in LSI into Dynamics’ Account record. While configuring the data pipeline from LinkedIn, customers have the option to automatically update the data every 24 hours.     

| Entities | Parameter information |
|----------|-----------------------|
| Company Profile |•  LinkedIn ID<br>•  Company Page URL<br>•  Company Name<br>•  Industry<br>•  Global Employee Count<br>•  Global Employee Growth (%)<br>•  Headquarters City<br>•  Headquarters State<br>•  Headquarters Country<br>•  Company Website URL<br>•  Last Update |
| Personas |•  Name<br>•  Employee Count<br>•  Employee Growth |

### See also

[Install or delete LinkedIn Sales Insights solution](install-lsi-solution.md)
