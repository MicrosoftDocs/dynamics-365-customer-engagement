---
title: Operation type for knowledge article schema mapping
description: Select an operation type for knowledge article schema mapping
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: conceptual
ms.date: 02/06/2023
ms.custom: bap-template
---

# Operation type for knowledge article schema mapping (preview)

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]
>

While adding an integrated search provider, you'll need to to configure the knowledge article schema for ingestion. To do this, you'll need to select an option on the **Knowledge article schema** section. If you select **Field Mapping**, you'll need to upload the article HTML file and then define the operation type for the knowledge article attributes in the **Mapping** section.

## Operation type mapping options

In the Mapping section, select the operation type from the dropdown list. You can select from the following options.

- Regex: Select this when you want to use Regex patterns to extract values from their source website. When you select this option, the source property will be a text area where you can enter the regex pattern. The string from their website's HTML that matches this pattern will be used to map to the corresponding knowledge article field.

- Direct: Select this when you want to map the value of any meta tag from its source website directly to any knowledge article field. The source property dropdown will list all the meta tags extracted from the sample website.

- Constant: Select this when you want to provide a constant value to any knowledge article field. The source property will be a text area where they can enter the constant value.

- RegexUrl: This option is similar to Regex. Select this only when you want to find matches in the URL of the source website.

## Next steps

For more information on adding an integrated search provider, go to: [Provision, add, and manage integrated search providers (preview)](add-search-provider.md#provision-add-and-manage-integrated-search-providers-preview).