---
title: Import custom  insights model into Dataverse
description: Learn how to import your custom insights model into Dataverse to display insights.
author: udaykirang
ms.author: udag
ms.reviewer: shujoshi
ms.topic: how-to
ms.collection: 
ms.date: 06/09/2023
ms.custom: bap-template
---

# Import custom insights model into Dataverse (preview)

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

As seller insights are generated from custom insights model, you must import your custom insights model into Dataverse. Before importing the model, map your custom attributes with the attributes in the `msdyn_salessuggestion` entity in Dataverse. 

## License and role requirements

| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## How to import data model into Dataverse

The following diagram illustrates the process of importing the custom model into Dataverse.

:::image type="content" source="media/si-import-suggesstions-model.svg" alt-text="An flow diagram of importing custom data model into Microsoft Dataverse.":::  

To import and map the attributes, follow these steps:
1.	[Understand the `msdyn_salessuggestion` entity](#import-insights-model-into-dataverse-preview).
1.	Map the attributes from your custom model with attributes in the `msdyn_salessuggestion` entity. You can use various methods to map the custom attributes such as Web APIs, comma-separated values (.csv), or XML Spreadsheet 2003 (.xml).
1.	Import your mapped attribute schema into Dataverse for Dynamics 365 Sales to access your data and show the insights. More information: [Map and import schema into Dataverse](#map-and-import-schema-into-dataverse).

## Understand the msdyn_salessuggestion entity

The `msdyn_salessuggestion` entity helps you in importing your custom insights data into Dynamics 365 Sales. The custom attributes in your data may differ based on your data. To help ensure that the insights surface at the right place with the right actions, map your custom attribute to the attributes in the `msdyn_salessuggestion` entity.

Let’s understand the `msdyn_salessuggestion` entity attributes in detail.

| Attribute | Logical or schema name | Attribute type | Description |
|-----------|------------------------|----------------|-------------|
| Related record | `msdyn_relatedrecord` | Lookup | Store the parent record for insight and customized for other entities that support 1:N relationships.<br>By default, the relationship is provided with the Account entity. |
| Name | `msdyn_name` | Primary field | Name of the suggestion. |
| Sales motion | `msdyn_salesmotion` | Optionset | Type of insight.<br>For example, New, Relationship Management, or True Up. |
| Solution area | `msdyn_solutionarea` | Optionset | Broad category of the product or SKU. |
| Sales play | `msdyn_salesplay` | Optionset | Narrow category of product, SKU, or sales strategy. |
| Suggestion reason | `msdyn_suggestionreason` | String | Rationale or justification behind a particular insight that is provided. |
| Suggestion insights | `msdyn_insight` | Multiline string | List of insights (the multi-line text is separated by Windows or Unix newline \r\n or \n). For example:
Line1\nLine2\nLine3 is displayed in the widget as:<br>•	Line1<br>•	Line2<br>•	Line3 |
| Potential revenue | `msdyn_potentialrevenue` | Currency | The estimated revenue that this insight can bring. |
| Owner | `ownerid` | User/team lookup | Owner's name on the record. |
| statecode<br>statuscode | `statecode` <br> `statuscode`| Optionset | Customizable state and status of insight. The out-of-the-box values for `statcode` is:<br>•	Open (shown in worklist)<br>•	Completed (positive disposition)<br>•	Declined (negative disposition)<br>•	Qualified (converted to opportunity or engagement) |
| Expiry date | `msdyn_expirydate` | DateTime | Expiry date of the insight. |
| Suggested date | `msdyn_suggesteddate` | DateTime | Due date of the insight. |
| Feedback reason | `msdyn_feedbackreason` | String | Capture reason given by seller for positive or negative when the feedback is **Others**. |

## Map and import schema into Dataverse

Use methods such as Web APIs, comma-separated values (.csv), or XML Spreadsheet 2003 (.xml) format to map custom attributes and create the schema. After mapping the custom attributes with the `msdyn_salessuggestion` entity, you must import the schema into Dataverse. This enables the insights to be displayed in the records in Dynamics 365 Sales.

To know more on how to import data into Dataverse, see:
-	For Web APIs: [Work with data using code in Microsoft Dataverse](/power-apps/developer/data-platform/work-with-data).
-	For comma-separated values (.csv), XML Spreadsheet 2003 (.xml), or text files: [Import data](/power-apps/developer/data-platform/import-data).

### See also

[Enable seller insights](enable-seller-insights.md)  
[Get intelligent insights to improve sales](seller-insights-intro.md)

