---
title: "Work with segments in real-time marketing (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to work with real-time marketing segments in Dynamics 365 Marketing."
ms.date: 04/23/2021
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Work with segments in real-time marketing

> [!IMPORTANT]
> A preview feature is a feature that is not complete, but is made available before it’s officially in a release so customers can get early access and provide feedback. Preview features aren’t meant for production use and may have limited or restricted functionality.
> 
> Microsoft doesn't provide support for this preview feature. Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions. Preview features aren’t meant for production use, especially to process personal data or other data that are subject to legal or regulatory compliance requirements.

Real-time marketing uses [segments](segmentation-lists-subscriptions.md) directly from outbound marketing and [Customer Insights](/dynamics365/customer-insights/index). You can view the segments available to you in real-time marketing by going to **Audience** > **Segments**.

> [!div class="mx-imgBorder"]
> ![Screenshot of the segments list in real-time marketing](media/real-time-marketing-segments.png)

## Segments from outbound marketing

To create a journey based on a segment from outbound marketing:

1. Go to **Audience** > **Segments**.
1. Select any segment, then select **+New journey** in the top ribbon.

A new screen will open allowing you to use your selected segment to start your **Segment-based** journey.

You can also start a new journey from the segment details page.

To create a journey from the details page:

1. Go to **Audience** > **Segments**.
1. Select the name of any segment.
1. From the details page, select **+New journey** in the top ribbon

## Create a new segment within your customer journey

You can create a new segment directly within the customer journey editor by selecting any **Attribute** tile, then going to **Segment** > **Look for segment** > **+New segment** in the right-hand pane.

This will take you directly to the segment builder, where you can create and save your segment.

> [!div class="mx-imgBorder"]
> ![Screenshot of selecting the +New segment option](media/real-time-marketing-segment-from-journey.png)

## Edit your segment

To edit your segment, select any segment name from the segments list. This will take you to the details view. Select **Open Segment** on the top ribbon. This will open the selected segment in its source builder. In the builder, select **Edit** to edit your segment.

You can determine the source of the segment by looking at the **Source** column in the segments list.

## Segments created in Customer Insights

If you have a subscription to [Dynamics 365 Customer Insights](/dynamics365/customer-insights/index) and have connected your instance to Dynamics 365 Marketing, segments from Customer Insights will also be available to you in real-time marketing.

You can determine the source of your outbound Marketing segment or your Customer Insight segment when you make segment selections in your customer journey creation.
![image](https://user-images.githubusercontent.com/82061205/115825397-39934a80-a3be-11eb-8833-0040b6f6bf47.png)

Learn more about [setting up and managing a Customer Insights connection to Dynamics 365 Marketing](/customer-insights/audience-insights/manage-environments).

## Exclusion segment

To exclude a segment in your customer journey, go to the right pane in the journey editor and select **Entry criteria**. Then, go to **Exclude this segment** and select any segment you want to exclude.

> [!NOTE]
> The segments shown for exclusion are based on the entry audience entity type. For example, if the entry audience segment is based on the **Contact** entity, only contact-based segment will be shown.

## Conditioning your customer journey based on a segment

To add a segment to a condition, select an **Attribute** in your customer journey, then add a condition in the pane on the right side of the page.

## Suppression segments

You can use a segment as an exit criterion for your customer journey.

To use a suppression segment, select **Exit criteria** in the right pane in the customer journey editor. Then, choose a segment under **Exit by segment**.

> [!div class="mx-imgBorder"]
> ![Screenshot of suppression segment selection](media/real-time-marketing-suppression.png)
