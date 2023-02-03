---
title: Configure advanced options for inspections (contains video)
description: Learn how to configure more advanced scenarios for inspections in Dynamics 365 Field Service.
ms.date: 02/02/2023
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

In addition to simple questions, Dynamics 365 Field Service also supports branching questions and conditional logic for [inspections](inspections.md). Other advanced scenarios include copying inspection templates, managing translations, and exporting inspections.

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RE4JiMF]

## Branching and conditional logic

The inspection can be configured to look and act differently based on the answers when a technician fills it out.

Go to the **Logic** section of the designer form to add branching and conditional logic to the inspection.

:::image type="content" source="media/inspection-logic-tab.png" alt-text="Screenshot of the logic designer for Field Service inspections.":::

Based on the response to an inspection question, options include:

- **Make page visible**: Show a page of questions when the condition is true.

- **Show the question**: Show a specific when the condition is true. The visibility of a question is mapped to a single rule. Add more conditions in the rule if you want input from multiple questions to determine whether this question is shown.

- **Change to required**: Question becomes required when the condition is true.

- **Skip to question**: When the condition is true, then the focus shifts to the selected question.

## Copy inspections

You can make a copy of an inspection to quickly create similar inspections.

Open the list of inspections and select an inspection template and select **Copy** in the command bar. The system creates a new inspection draft with the same questions and appends (1) to the inspection name.

## Create new versions of the same inspection

Once you published an inspection, it becomes read-only. To make changes, open the inspection template and select **Revise**. The system creates a new version of the inspection template in a draft state. To use your updated version of the inspection and deactivate the current version, select **Publish**.

:::image type="content" source="media/inspection-revise-version.png" alt-text="Screenshot with versioning options for inspections.":::

Versions of an inspection are listed in the **Versions** tab.

Service tasks always use the inspection version that was active when a service task got created. revising an inspection won't change service tasks retroactively.

## Export inspection as blank PDF

Export an inspection as PDF can help if you need to send it in an email. The resulting PDF contains only the questions. While you can answer the questions in the PDF and save the file, no data flows back into Field Service.

Ensure you saved and published the inspection. Open the inspection and select **Export** > **Export to PDF**. A PDF file with the blank inspection questions will download automatically.

:::image type="content" source="media/export-inspection-template.png" alt-text="Screenshot of the export as PDF option.":::

> [!NOTE]
> Questions that interact with the system have limited functionality when exported. For example, the entity lookup question type won't reference the Dynamics 365 database records.

## Export inspection responses as PDF

Inspection responses can also be exported as a PDF from the work order service task. Select **Export Responses** on the work order service task to get a PDF with the responses filled in.

:::image type="content" source="media/export-inspection-response-as-pdf.png" alt-text="Screenshot showing export response as PDF experience on service task.":::

This export doesn't support custom date or number formats, right-to-left languages, Hindi, and Chinese. set using the personalization settings.

## Import and export inspection templates

Administrators can export inspection templates as json objects to import them to another environment. For example, to migrate an inspection from a test environment to a production environment.

Open the inspection and select **Export** > **Export to json**.

:::image type="content" source="media/importJsonFile.png" alt-text="Screenshot of the option to import from json.":::

## Language translations

You can add language variations for each inspection.

Open an inspection, and select the **Translation** tab. Choose a language from the dropdown and enter the translation for each question. Then, save and publish the inspection.

:::image type="content" source="media/translationimage3.png" alt-text="Screenshot of the translation tab on an inspection.":::

> [!IMPORTANT]
> [Enable the languages on the your environment](/power-platform/admin/enable-languages) for your translations to let technicians view translated inspections on the mobile app.

## Inspections for customer assets

Relate an inspection to a customer asset to build a [service history](service-history.md). Enter the customer asset in the **Service Task Relates To** section of the work order service task that uses the inspection.

:::image type="content" source="media/inspections-wost-customer-asset.png" alt-text="Screenshot of the work order service task showing the service task relates to section, highlighting an associated customer asset.":::

Associating a customer asset lets the technician know which customer asset to inspect. From the customer asset, they can see all related inspection history.

> [!TIP]
> Relate a work order incident type to a customer asset and the related work order service tasks are automatically related to the customer asset.

### Inspecting multiple assets at a location

There are two options if a technician needs to inspect 10 customer assets at a location:

- Create one inspection with 10 questions. One question for each asset and relate the inspection to a single service task. A single service task with multiple questions is quicker to fill out.
- Create 10 work order service tasks, each with one inspection. Work order service tasks related to customer assets can build a service history. Creating 10 service tasks, each related to a different customer asset, helps to build that service history.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
