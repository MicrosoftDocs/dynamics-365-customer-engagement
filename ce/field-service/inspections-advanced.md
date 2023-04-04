---
title: Configure advanced options for inspections (contains video)
description: Learn about advanced ways of working with inspections in Dynamics 365 Field Service.
ms.date: 03/15/2023
ms.topic: how-to
ms.custom: bap-template
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: josephshum-msft
ms.author: jshum
search.app: 
  - D365CE
  - D365FS
---

# Configure advanced options for inspections

Along with simple lists of questions, [inspections](inspections.md) can incorporate more advanced scenarios like branching and conditional logic. Other advanced ways to use inspections include copying inspections to serve as templates, adding translations, importing and exporting inspections, and relating inspections to assets to build service histories.

Watch a brief video overview:

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RE4JiMF]

## Add branching and conditional logic

An inspection can look and act differently depending on how the technician answers.

Add branching and conditional logic in the **Logic** section of the inspection designer.

Based on the response to a question, inspections can:

- **Make Page visible**: If an inspection includes more than one page, show a specific page when the condition is true.

- **Show the question**: Show a specific question when the condition is true.

    A question's visibility maps to a single rule. If you want multiple questions to determine whether the question is shown, add more conditions to the rule.

- **Change to Required**: Make the question required when the condition is true.

- **Skip to question**: Skip to a specific question when the condition is true.

## Copy an inspection

Copy an inspection to quickly create similar inspections.

1. Open the list of inspections and select one.

1. Select **Copy** in the command bar.

1. Modify the new inspection draft as needed.

1. Save and publish the inspection.

## Create a new version of an inspection

When you publish an inspection, it becomes read-only. To change it, you need to create a new version. Versions of an inspection are listed in the **Versions** tab.

Revising an inspection doesn't change service tasks retroactively. Service tasks keep the inspection version that was active when the task was created.

1. Open the list of inspections and select one.

1. Select **Revise** in the command bar.

    The system creates a new version of the inspection in a draft state.

1. Modify the draft as needed.

1. To use the new version and deactivate the current one, select **Publish**.

:::image type="content" source="media/inspection-revise-version.png" alt-text="Screenshot with versioning options for inspections.":::

## Export an inspection as a PDF file

Export an inspection as a PDF file to send the questions in an email. Although the questions can be answered in the file, they no longer interact with the Dynamics 365 system (for example, lookups don't work), and they don't flow back into Field Service.

1. Open the list of inspections and select one.

1. Select **Export** > **Export to PDF** to download the file.

:::image type="content" source="media/export-inspection-template.png" alt-text="Screenshot of the export as PDF option.":::

## Export inspection responses as a PDF file

Export inspection responses as a PDF file to share them by email, for instance. This option doesn't support custom date or number formats, right-to-left languages, Hindi, or Chinese.

In the work order service task, select **Export Responses** to download them as a PDF file.

:::image type="content" source="media/export-inspection-response-as-pdf.png" alt-text="Screenshot showing export response as PDF experience on service task.":::

## Import and export inspections

Administrators can export inspections as JSON objects to import them to another environment; for example, from a test environment to a production environment.

1. Open the list of inspections and select one.

1. Select **Export** > **Export to json** to download the file in JSON format.

:::image type="content" source="media/importJsonFile.png" alt-text="Screenshot of the option to import from json.":::

## Add translations

Add a variation of an inspection for each language your technicians speak.

> [!IMPORTANT]
> [Turn on languages in your environment](/power-platform/admin/enable-languages) to let technicians view translated inspections in the mobile app.

1. Open the list of inspections, select one, and then select the **Translation** tab.

1. Select a language from the list and enter the translation for each question.

1. Save and publish the inspection.

:::image type="content" source="media/translationimage3.png" alt-text="Screenshot of the translation tab on an inspection.":::

## Associate inspections with customer assets

Associate an inspection to a customer asset to let technicians know which asset to inspect and to build a [service history](service-history.md). Enter the customer asset in the **Service Task Relates To** tab of the work order service task that uses the inspection.

:::image type="content" source="media/inspections-wost-customer-asset.png" alt-text="Screenshot of the work order service task showing the Service Task Relates To tab, highlighting an associated customer asset.":::

> [!TIP]
> Relate a work order incident type to a customer asset and the related work order service tasks are automatically related to the customer asset.

### Inspecting multiple assets at a location

If technicians need to inspect multiple customer assets at a location, you have two options:

- Create an inspection with one question for each asset and relate the inspection to a single service task. A single service task with multiple questions is quicker to fill out.
- Create a work order service task for each asset, each with one inspection. Work order service tasks related to customer assets can build a service history. Creating service tasks for customer assets helps to build that service history.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
