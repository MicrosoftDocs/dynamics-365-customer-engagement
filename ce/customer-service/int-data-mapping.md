---
title: Configure knowledge article schema mapping (preview)
description: Learn about knowledge article schema mapping.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: how-to
ms.date: 02/07/2023
ms.custom: bap-template
---

# Configure knowledge article schema mapping (preview)

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]
>

To add an integrated search provider you'll need to configure the knowledge article schema for data ingestion. To do this, you'll need to select an option from the **Knowledge article schema** section:

- **Field mapping**
- **JSON Schema**

> [!NOTE]
> You won't be able to change the configuration method after you have saved it.

## Field mapping

1. Save the article as an .html file, and then upload the file by selecting **Choose file**. You'll view all the meta tags corresponding to your HTML file in the **Meta tags settings** section.
1. You can select all the meta tags by selecting the **Select all below meta tags** checkbox or select only the required meta tags.

    The meta tags that you select will be available in the **Mapping** section. If you don't select any meta tags, you'll only see the **HTMLTitle** source property, which is available by default.
1. Select **Next**.
1. On the **Mapping** section, select the **Operation Type** and **Source Property** for the mandatory knowledge article attributes, which are **External Reference Id**, **Title**, and **Content**. For mre information on the various operation types, go to [Operation type mapping options](#operation-type-mapping-options).
1. To add additional article attributes, select **Add Row**, and then select the **Article Attribute**, **Operation Type**, and the **Source Property** from the respective dropdown lists.
1. You can also  delete the additional article attribute, by selecting **Delete**.
1. Select **Validate mapping**.
    1. Select **Next**.

You'll see a confirmation message when the validation is successful. In case of an error message, you'll need to check the entries in the mapping table.

## JSON method

1. Copy and paste your article properties and schema JSON in the field provided to you. For more information on creating the JSON schema, go to [Develop metadata mapping schema for knowledge articles](int-search-metadata-schema.md#develop-metadata-mapping-schema-for-knowledge-articles)
1. Select **Validate json**.
 
    You'll get a message to denote whether the JSON validation has passed or failed. In case of an error, the error message will state the parameter with the incorrect value.
1. After the validation is successful, select **Next** to go to the **Refresh Schedule** section.

## Operation type mapping options

- **Regex**: Select this when you want to use Regex patterns to extract values from their source website. When you select this option, the source property will be a text area where you can enter the regex pattern. The string from their website's HTML that matches this pattern will be used to map to the corresponding knowledge article field.

- **Direct**: Select this when you want to map the value of any meta tag from its source website directly to any knowledge article field. The source property dropdown will list all the meta tags extracted from the sample website.

- **Constant**: Select this when you want to provide a constant value to any knowledge article field. The source property will be a text area where they can enter the constant value.

- **RegexUrl**: This option is similar to Regex. Select this only when you want to find matches in the URL of the source website.

## Next steps

For more information on adding an integrated search provider, go to: [Provision, add, and manage integrated search providers (preview)](add-search-provider.md#provision-add-and-manage-integrated-search-providers-preview).