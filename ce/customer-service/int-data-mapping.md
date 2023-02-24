---
title: Configure knowledge article schema mapping (preview)
description: Learn about knowledge article schema mapping.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: how-to
ms.date: 02/24/2023
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

To add an integrated search provider, you need to configure the knowledge article schema for data ingestion. You need to select an option from the **Knowledge article schema** section:

- **Field mapping**
- **JSON Schema**

> [!NOTE]
> You won't be able to change the configuration method after you have saved it.

## Language mapping

Irrespective of the configuration type that you use, if you have selected languages to be mapped in the **Authentication and testing** section, you must maintain the mapping for language locale either in the **JSON Schema** or in the **Knowledge article schema mapping** section. For more information on language locale values, go to: [Language and locale descriptors in the product and in Help](/fin-ops-core/dev-itpro/help/language-locale.md).

## Use field mapping

Through field mapping, you'll be able to map a value to the article attributes of the knowledge article entity from your source property or website. You need to use an operation type and then select the source property for the mapping.

Article attributes are the knowledge article target field values. Operation types are the mapping patterns that map the source article to the article attributes of the knowledge article entity. More information: [Operation type mapping options](#operation-type-mapping-options). Source Property is the value that you define for each operation type. For example, if you select the **Direct** operation type, you'll have to select from the previously selected meta tags or the **HTML-Title** or **HTML-Body** tags.

1. Save the article as an HTML file, and then upload the file by selecting **Choose file**. Make sure that the file name is fewer than 99 letters. You can view all the meta tags corresponding to your HTML file in the **Meta tags settings** section.
1. You can select all the meta tags by selecting the **Select all below meta tags** checkbox or select only the required meta tags.

    The meta tags that you select will be available in the **Mapping** section. If you don't select any meta tags, you only see the **HTML-Title** and **HTML-Body** source properties, which are available by default.
1. Select **Next**.
1. On the **Mapping** section, select the **Operation Type** and **Source Property** for the mandatory knowledge article attributes, which are **External Reference Id**, **Title**, and **Content**. Make sure that the **External Reference Id** value is unique. For more information on the various operation types, go to [Operation type mapping options](#operation-type-mapping-options).
1. To add more article attributes, select **Add Row**, and then select the **Article Attribute**, **Operation Type**, and the **Source Property** from the respective dropdown lists.
1. You can also delete the article attributes, by selecting **Delete**.
1. Select **Validate mapping**. The values provided are used to determine the values of the attributes against the HTML file that you uploaded.
   The entries in the mapping table and the Regex patterns are validated. There are no validations for RegexUrl.
1. Select **Next**.

If the validation is successful, you'll see a confirmation message. If the validation is not successful, you'll see an error message. Depending on the error message, you'll need to either check the entries in the mapping table or the regex patterns that you have provided for the article attributes.

## Use JSON

1. Copy and paste your article properties and schema JSON in the field provided to you. For more information on creating the JSON schema, go to [Develop metadata mapping schema for knowledge articles (preview)](int-search-metadata-schema.md#develop-metadata-mapping-schema-for-knowledge-articles-preview)
1. Select **Validate json**.
 
    You'll get a message to denote whether the JSON validation has passed or failed. If there is an error, the error message will state the parameter with the incorrect value.
1. After the validation is successful, select **Next** to go to the **Refresh Schedule** section.

### Operation type mapping options

- **Regex**: Select this when you want to use Regex patterns to extract values from their source website. When you select this option, the source property will be a text area where you can enter the regex pattern. The string from your website's HTML that matches this pattern will be used to map to the corresponding knowledge article field.

- **Direct**: Select this when you want to map the value of any meta tag from its source website directly to any knowledge article field. The **Source Property** dropdown list shows all the meta tags extracted from the sample website along with **HTML-Title** and **HTML-Body** source properties, which are available by default.

- **Constant**: Select this when you want to provide a constant value to any knowledge article field. The source property will be a text area where they can enter the constant value.

- **RegexUrl**: This option is similar to Regex. Select this only when you want to find matches in the URL of the source website.

## Next steps

For more information on adding an integrated search provider, go to: [Add and manage integrated search providers (preview)](add-search-provider.md#add-and-manage-integrated-search-providers-preview).