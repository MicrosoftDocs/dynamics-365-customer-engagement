---
title: Import a custom insights model into Dataverse
description: Learn how to import your custom insights model into Dataverse to display insights.
author: udaykirang
ms.author: udag
ms.reviewer: shujoshi
ms.topic: how-to
ms.collection: 
ms.date: 06/09/2023
ms.custom: bap-template
---

# Import a custom insights model into Dataverse (preview)

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

Because seller insights are generated from your custom insights model, you must import that model into Dataverse. However, before you import the model, map your custom attributes with the attributes in the `msdyn_salessuggestion` entity in Dataverse.

## License and role requirements

| Requirement type | You must have |
|------------------|---------------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator<br>More information: [Predefined security roles for Sales](security-roles-for-sales.md) |

## Import the data model into Dataverse

The following diagram illustrates the process of importing the custom model into Dataverse.

:::image type="content" source="media/si-import-suggesstions-model.svg" alt-text="Flow diagram of the process of importing the custom data model into Dataverse.":::

To import and map the attributes, follow these steps:

1. Make sure that you [understand the msdyn\_salessuggestion entity](#understand-the-msdyn_salessuggestion-entity).
1. Map the attributes from your custom model with attributes in the `msdyn_salessuggestion` entity. You can use various methods to map the custom attributes, such as Web APIs, comma-separated values (.csv) files, or XML Spreadsheet 2003 (.xml) files.
1. Import your mapped attribute schema into Dataverse, so that Dynamics 365 Sales can access your data and display the insights. For more information, go to the [Map the schema and import it into Dataverse](#map-the-schema-and-import-it-into-dataverse) section.

## Understand the msdyn_salessuggestion entity

The `msdyn_salessuggestion` entity helps you import your custom insights data into Dynamics 365 Sales. The custom attributes in your data might vary, based on the data. To help ensure that the insights are surfaced in the correct place and with the correct actions, map your custom attributes to the attributes in the `msdyn_salessuggestion` entity.

Use the following table to get a detailed understanding of the `msdyn_salessuggestion` entity attributes.

| Attribute | Logical or schema name | Attribute type | Description |
|-----------|------------------------|----------------|-------------|
| Related record | `msdyn_relatedrecord` | Lookup | <p>This attribute stores the parent record for the insight and is customized for other entities that support one-to-many (1:N) relationships.</p><p>By default, the relationship is provided through the account entity.</p> |
| Name | `msdyn_name` | Primary field | The name of the suggestion. |
| Sales motion | `msdyn_salesmotion` | Optionset | The type of insight, such as *New*, *Relationship Management*, or *True Up*. |
| Solution area | `msdyn_solutionarea` | Optionset | The broad category of the product or stock keeping unit (SKU). |
| Sales play | `msdyn_salesplay` | Optionset | The narrow category of the product, SKU, or sales strategy. |
| Suggestion reason | `msdyn_suggestionreason` | String | The rationale or justification behind a specific insight that is provided. |
| Suggestion insights | `msdyn_insight` | Multiline string | <p>A list of insights. The multiline text is separated by Windows or Unix newline characters (\\r\\n or \\n). For example, *Line1\\nLine2\\nLine3* is displayed in the widget as:</p><ul><li>Line1</li><li>Line2</li><li>Line3</li></ul> |
| Potential revenue | `msdyn_potentialrevenue` | Currency | The estimated revenue that the insight can bring. |
| Owner | `ownerid` | User/team lookup | The owner's name on the record. |
| statecode<br>statuscode | `statecode`<br>`statuscode`| Optionset | <p>The customizable state and status of the insight. The out-of-box values are:</p><ul><li>*Open* (shown in the work list)</li><li>*Completed* (positive disposition)</li><li>*Declined* (negative disposition)</li><li>*Qualified* (converted to an opportunity or engagement)</li></ul> |
| Expiry date | `msdyn_expirydate` | DateTime | The expiry date of the insight. |
| Suggested date | `msdyn_suggesteddate` | DateTime | The due date of the insight. |
| Feedback reason | `msdyn_feedbackreason` | String | The capture reason that the seller gave for positive or negative feedback when the feedback is *Others*. |

## Map the schema and import it into Dataverse

Use methods such as Web APIs, comma-separated values (.csv) files, or XML Spreadsheet 2003 (.xml) files to map custom attributes and create the schema. After you map the custom attributes with the `msdyn_salessuggestion` entity, you must import the schema into Dataverse. The insights can then be displayed in the records in Dynamics 365 Sales.

To learn more about how to import data into Dataverse, go to:

- For Web APIs: [Work with data using code in Microsoft Dataverse](/power-apps/developer/data-platform/work-with-data).
- For comma-separated values (.csv), XML Spreadsheet 2003 (.xml), or text files: [Import data](/power-apps/developer/data-platform/import-data).

### See also

[Enable seller insights](enable-seller-insights.md)  
[Get intelligent insights to improve sales](seller-insights-intro.md)
