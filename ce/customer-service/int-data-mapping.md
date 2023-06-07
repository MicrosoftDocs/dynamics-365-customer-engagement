---
title: Configure knowledge article schema mapping
description: Learn about knowledge article schema mapping.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: how-to
ms.date: 05/02/2023
ms.custom: bap-template
---

# Configure knowledge article schema mapping

To add an integrated search provider, you must configure the knowledge article schema for data ingestion. In the **Knowledge article schema** section, select one of the following configuration methods:

- **Field mapping**
- **JSON Schema**

> [!IMPORTANT]
> You can't change the configuration method after you save it.

## Language mapping

Regardless of the configuration method that you use, if you selected languages for mapping in the **Authentication and testing** section, you must maintain the mapping for language locale in either the **JSON Schema** section or the **Knowledge article schema mapping** section. [Learn more about language locale values.](/power-apps/developer/data-platform/reference/entities/languagelocale)

## Use field mapping

Through field mapping, you can map a value to the *article attributes* of the knowledge article entity from your source property or website. You must use an *operation type* and then select the *source property* for the mapping.

- **Article attributes**: The knowledge article target field values.
- **Operation types**: The mapping patterns that map the source article to the article attributes of the knowledge article entity. [Learn more about operation type mapping options.](#operation-type-mapping-options)
- **Source property**: The value that you define for each operation type. For example, if you select the **Direct** operation type, you must select among the previously selected meta tags, or the `HTML-Title` or `HTML-Body` tag.

To use field mapping, follow these steps:

1. Save the article as a **Web Page, HTML Only** file, and then upload the HTML file by selecting **Choose file**. Make sure that the file name has fewer than 99 characters.

    The **Meta tags settings** section shows all the meta tags that correspond to your HTML file.

1. Select the required meta tags. To select all the meta tags, select the **Select all below meta tags** checkbox.

    The meta tags that you select become available in the **Mapping** section. If you don't select any meta tags, the **Mapping** section shows only the **HTML-Title** and **HTML-Body** source properties, which are available by default.

1. Select **Next** to go the **Mapping** section, or select **Save as draft** if you must still provide information for the section.
1. In the **Mapping** section, select the operation type and source property for the following mandatory knowledge article attributes: **External Reference Id**, **Title**, and **Content**. Make sure that the **External Reference Id** value is unique. [Learn more about the different operation types.](#operation-type-mapping-options)
1. To add more article attributes, select **Add Row**, and then select the article attribute, operation type, and source property in the appropriate dropdown lists. You can also delete article attributes by selecting **Delete**.
1. Select **Validate mapping**. The provided values are used to determine the values of the attributes against the HTML file that you uploaded.

    The entries in the mapping table and the regular expression (regex) patterns are validated. There are no validations for **RegexUrl**.

1. Select **Next** to go the next section, or select **Save as draft** if you must still provide information for the section.

If the validation is successful, you receive a confirmation message. If the validation isn't successful, you receive an error message. Depending on the error message, you must review either the entries in the mapping table or the regex patterns that you provided for the article attributes.

## Use JSON

1. Copy and paste your article properties and schema JavaScript Object Notation (JSON) code into the field that is provided. [Learn more about how to create the JSON schema.](int-search-metadata-schema.md)
1. Select **Validate json**.
 
    You receive a message that informs you whether the JSON validation passed or failed. If there is an error, the error message indicates the parameter that has the incorrect value.

1. After the validation is successful, select **Next** to go to the **Refresh Schedule** section, or select **Save as draft** if you must still provide information for the section.

### Operation type mapping options

- **Regex**: Select this option if you want to use regex patterns to extract values from the source website. In this case, the source property is a text area where you can enter the regex pattern. Whatever string from your website's HTML matches that pattern will be used to map to the corresponding knowledge article field.

    The regex patterns must have a capture group that is enclosed in parentheses, so that you can extract a specific portion of the matched text. Note that the extracted text will be from the first non-empty group of the first match. For more information, go to [Grouping constructs](/dotnet/standard/base-types/regular-expression-language-quick-reference#grouping-constructs). Here are some examples of regex patterns that can be used to extract content from a specific `div` tag:

    - **Based on the id attribute of the div tag**: `<div\b[^>]*id=\"your-id-name-here\"[^>]*>([\s\S]*?)<\/div>`
    - **Based on the class attribute of the div tag**: `<div\b[^>]*class=\"your-class-name-here\"[^>]*>([\s\S]*?)<\/div>`
    - **For content inside the body tag**: `<body[^>]*>([\s\S]*)<\/body>`
    - **For content inside the head tag**: `<head[^>]*>([\s\S]*)<\/head>`

    [Learn more about regex.](/dotnet/standard/base-types/regular-expression-language-quick-reference)

- **Direct**: Select this option if you want to map the value of any meta tag from the source website directly to any knowledge article field. The **Source Property** dropdown list shows all the meta tags that have been extracted from the sample website, together with **HTML-Title** and **HTML-Body** source properties, which are available by default.

    If you select the **Direct** operation type and the `og: url` meta tag from the source property, the value of the `og: url` meta tag from the source property is mapped to the corresponding knowledge article attribute.

- **Constant**: Select this option if you want to provide a constant value to any knowledge article field. In this case, the source property is a text area where you can enter the constant value.
- **RegexUrl**: This option resembles **Regex**. Select it if you want to find matches in the URL of the source website only. The regex patterns must be created as described for the **Regex** operation type. For example, to map the whole source website URL to a knowledge attribute field, select **RegexUrl** as the operation type, and use the `(. *)` pattern in the source property.

## Next steps

[Learn more about how to add integrated search providers.](add-search-provider.md#manage-integrated-search-providers)
