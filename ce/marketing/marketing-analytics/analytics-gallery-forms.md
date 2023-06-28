---
title: "Marketing form submission report for Dynamics 365 Marketing (Dynamics 365 Marketing) | Microsoft Docs"
description: "See all the details of your marketing form submissions in one report, and slice and dice over timeline, related marketing messaging, and automation."
ms.date: 09/19/2022
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: cabeln
ms.author: cabeln
ms.reviewer: alfergus
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Marketing form submission report

Use this marketing analytics report to get insights into the submission stream of your marketing forms. You'll be able to see all the details of your marketing form submissions in one report, and then slice and dice over the timeline, related marketing messaging, and automation.

Use the following links to download a template for running the report on your own organization and a sample report filled with sample data.

|Download report template  |Download sample report  |
|---------|---------|
[![Download template.](media/IconDownloadTemplate30.png)](https://github.com/microsoft/Dynamics-365-for-Marketing---Power-BI-Reporting/raw/master/PowerBI-Templates/MarketingAnalyzers%20-%20Form%20Submissions.pbit)|[![Download sample report](media/IconDownloadReport30.png)](https://github.com/microsoft/Dynamics-365-for-Marketing---Power-BI-Reporting/raw/master/pbx%20files/MarketingAnalyzers%20-%20Form%20Submissions.pbix)|

> [!NOTE]
> You can find the full list of marketing analytics downloads in the [marketing analytics reporting gallery](analytics-gallery-start.md#gallery).

In addition to the [common report pages](analytics-gallery-framework.md#common-report-pages), this analytics report includes the following pages:

- [Home page](#home-page)
- [A timeline of form submissions](#submission-timeline)
- [Details of form submissions](#submission-details)
- [Submission values](#submission-values)
- [Conversion leaderboard](#leaderboard)

<a name="home-page"></a>

## Marketing-form submission report home page

> [!TIP]
> The report home page gives a quick overview on your marketing forms and the submission volume.

Each report includes a filter pane on the left that lets you quickly select the relevant marketing activities to focus on. You can also chose the relevant time frame for your exploration.

![marketing-form submission report home page.](media/MarketingForm/FormSubmissionHome.png "Marketing-form submission report home page")

<a name="submission-timeline"></a>

## Marketing-form submission timeline

Use this report page to see a timeline of form-submission history across all your marketing forms.

![marketing-form submission timeline.](media/MarketingForm/SubmissionTimeline.png "Marketing-form submission timeline")

<a name="submission-details"></a>

## Marketing-form submission details

You can also find a more detailed view of all form submissions.

![marketing-form submission details.](media/MarketingForm/SubmissionDetails.png "Marketing-form submission details")

<a name="submission-values"></a>

## Marketing-form submission value report

See what values have been submitted against which fields for all marketing forms.

![Submitted values report.](media/MarketingForm/SubmissionValues.png "Submitted values report")

<a name="leaderboard"></a>

## Conversion leaderboard

This leaderboard displays various types of conversions from your marketing forms. It shows which forms:

- Attracted the most submissions from new and returning visitors.
- Created the most new contacts or updated the most existing contacts.
- Created the most new leads or updated the most existing leads.

![Conversion leaderboard from marketing-form submissions.](media/MarketingForm/SubmissionConversionLeaderboard.png "Conversion leaderboard from marketing-form submissions")

## Map GUIDs to web browser and operating system names

Exported data for interactions like **EmailOpened**, **WebsiteVisited**, **WebsiteClicked**, etc. contain information about web browsers and operating systems. **BrowserId** and **OperatingSystemId** columns contain GUIDs, whereas **BrowserVersion** and **OperationSystemVersion** columns contain the version number of the particular web browser/operating system. These GUIDs can be mapped to web browsers and operating system using the information in the tables below.

### Web browsers

| BrowserId                            | Name              |
| ------------------------------------ | ----------------- |
| 2F5C5058-9D1F-4969-84DD-17D0E67BB4A4 | Edge              |
| 5BAEADFC-25D3-4059-BC7B-F5AE56E6D530 | Opera             |
| F9B18F1B-89DC-48E3-A0AF-0532CE0E23F7 | Netscape          |
| A44C2F62-82FA-4E28-B3FF-E5DB4861CCDB | Sea Monkey        |
| D28C8F68-AAEB-4F70-8F25-E898B9C303E7 | Camino            |
| 807C4A91-D194-443B-8052-5A4F2945FBA0 | Firefox           |
| 881B893B-CD9D-4382-BC44-6CB483AE20F2 | UC Browser        |
| E075C8DF-A34A-4015-B9DD-54EAB8192458 | Sleipnir          |
| E9F61625-B032-449B-8CD6-254ED21F39E4 | Internet Explorer |
| A672EC74-B253-4AA3-9158-D4F7CD9818B8 | Outlook           |
| 7759E90A-93D0-4891-A6F3-A17D05335BF4 | Comodo Dragon     |
| A90B7CB3-DDC2-456D-9C8D-E90104ED6D81 | Chrome Plus       |
| A8A2DC38-6ACD-42C3-999B-5599E31ACA3B | Chrome            |
| B0541878-4329-4F38-8B2F-54FEA245EE22 | Rekonq            |
| E54FFD0F-C94D-435F-8A97-407C634CBDA1 | Safari            |
| 30F089C6-C601-42D5-9922-366C0ACFAF40 | Konqueror         |  

### Operating systems

| OperatingSystemId                    | Name       |
| ------------------------------------ | ---------- |
| 2FD14342-0556-42BF-A155-7F1343CE16DF | Windows    |
| 307E8C83-FA4E-4D6D-8973-73B79F9D0101 | Symbian    |
| F2372FF7-5AA7-482C-99D7-EF2B1C8D64FF | Solaris    |
| 691FEE8E-7C8D-4EE4-BB40-5C924AFFD9FE | Mac OS X   |
| 407890B5-651F-4935-9D1C-4D146076BBFE | Linux      |
| CC324703-9D00-4CF9-BEE7-FA65B373841D | iOS        |
| 9D1DACFC-3270-40E8-85E3-64BB62B2C562 | Chrome OS  |
| 5B72CDD9-3277-4472-9051-D2631A2F69E9 | Fire OS    |
| DF7D6FF2-99A7-4E1D-96AF-0BBCC59CD7F8 | BlackBerry |
| DCB8D655-5B63-4A3A-92F5-3213686344FA | Bada       |
| 731CDF56-671E-4694-9685-71173E7E3412 | AIX        |
| 6B6B81D0-EF01-4B4D-8430-675DC31AE27D | Android    |
| 8C0667B0-492A-4872-BCDD-0A9278127BDB | Amiga      |

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
