---
title: Configure knowledge article schema mapping
description: Learn how to configure knowledge article schema mapping as part of adding an integrated search provider for Dynamics 365 Customer Service.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: how-to
ms.date: 07/03/2023
ms.custom: bap-template
---

# Configure knowledge article schema mapping

As part of [adding an integrated search provider](add-search-provider.md#add-integrated-search-providers) in Customer Service, you need to tell the service how to ingest the knowledge articles it receives from the provider. You do that by selecting and configuring a knowledge article schema. You can't change the schema after you save the configuration.

If you applied a language filter in the **Authentication and Testing** section, you must maintain the mapping for language locale either in the **JSON Schema** or in the **Knowledge article schema mapping** section. For more information on language locale values, go to: [Language (LanguageLocale) table/entity reference](/power-apps/developer/data-platform/reference/entities/languagelocale).

To start, select an option in the **Knowledge article schema** section:

- [**Field Mapping**](#field-mapping)
- [**JSON Schema**](#json-schema)

## Field mapping

With field mapping, you map a knowledge article received from the search provider (the source property) to an attribute of the knowledge article entity (the target), based on an operation type. You need to use an operation type and then select the source property for the mapping.

- **Article attributes**: The knowledge article target field values.
- **Operation types**: The mapping patterns that map the source article to the article attributes of the knowledge article entity. [Learn more about operation type mapping options.](#operation-type-mapping-options)
- **Source property**: The value that you define for each operation type. For example, if you select the **Direct** operation type, you must select among the previously selected meta tags, or the `HTML-Title` or `HTML-Body` tag.

1. Save the article locally as a **Web Page, HTML Only** file. Make sure the file name is fewer than 99 characters.
1. In the Customer Service admin center site map, **Knowledge article schema** > **Field Mapping** section, upload the file by selecting **Choose file**.

    All the meta tags found in your HTML file are listed in the **Meta tags settings** section.

1. Either select **Select all below meta tags** or select only the meta tags you need to map.

    The meta tags you select here become attributes you can select as source properties in the **Mapping** section. If you don't select any, only the default source properties **HTML-Title** and **HTML-Body** are available to map.

1. To go to the **Mapping** section, select **Next**. If you want to stop and come back to this point later, select **Save as draft**.
1. In the **Mapping** section, the mandatory knowledge article attributes are **External Reference Id**, **Title**, and **Content**. For each, select an [**Operation Type**](#operation-type-mapping-options) and a **Source Property**.

    Make sure the **External Reference Id** value is unique.

1. To add more article attributes, select **Add Row**, and then select an **Article Attribute**, **Operation Type**, and **Source Property**.

    You can also select **Delete** to delete an article attribute if needed.

1. Select **Validate mapping**.

    The service uses the values you entered to determine the values of the attributes against the HTML file you uploaded. It validates entries in the mapping table and Regex patterns. There are no validations for RegexUrl.

    If validation succeeds, you see a confirmation message. If validation fails, you see an error message. Depending on the error message, check either the entries in the mapping table or the regex patterns you entered.

1. Select **Next** to go the next section. If you want to stop and come back to this point later, select **Save as draft**.

## JSON schema

[Learn more about schema details to build a metadata mapping template](int-search-metadata-schema.md).

1. Copy and paste your article properties and schema JSON in the field provided to you
1. Select **Validate JSON**.

    If validation succeeds, you see a confirmation message. If validation fails, you see an error message that identifies the parameter that has an incorrect value.

1. Select **Next** to go the next section. If you want to stop and come back to this point later, select **Save as draft**.

## Operation type mapping options

- **Regex**: Uses [regex patterns](/dotnet/standard/base-types/regular-expression-language-quick-reference) to extract values from the source website. The source property is a text field where you can enter the regex pattern. The string from your website's HTML that matches this pattern is mapped to the corresponding knowledge article field.

    The regex patterns must have a [capture group](/dotnet/standard/base-types/regular-expression-language-quick-reference#grouping-constructs) enclosed in parentheses that allows you to extract a specific portion of the matched text. The text is extracted from the first nonempty group of the first match.

    Here are some examples of regex patterns to extract content from a specific div tag:

  - Based on the div tag ID: ``<div\b[^>]*id=\"your-id-name-here\"[^>]*>([\s\S]*?)<\/div>``
  - Based on the div tag class: ``<div\b[^>]*class=\"your-class-name-here\"[^>]*>([\s\S]*?)<\/div>``
  - For content inside the body tag: ``<body[^>]*>([\s\S]*)<\/body>``
  - For content inside the head tag: ``<head[^>]*>([\s\S]*)<\/head>``

- **Direct**: Maps the value of any meta tag from its source website directly to any knowledge article field. The **Source Property** list shows all the meta tags extracted from the sample website along with source properties **HTML-Title** and **HTML-Body**, which are available by default.

    If you select **Direct** as the operation type and **og: url** as the source property, then the value of the **og: url** meta tag from the source property is mapped to the corresponding knowledge article attribute.

- **Constant**: Enter a constant value in any knowledge article field. The source property is a text field where you can enter the constant value.

- **RegexUrl**: Like Regex, but looks for matches in the URL of the source website only. To map the entire source website URL to a knowledge attribute field, select **Regexurl** in the operation type, and use the (. *) pattern in the source property.

## Next steps

[Manage integrated search providers](add-search-provider.md#manage-integrated-search-providers)
