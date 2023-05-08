---
title: Improve sequence efficiency with insights
description: Sequence insights provide valuable data on the performance of sequences and their steps. 
author: udaykirang
ms.author: udag
ms.reviewer: shujoshi
ms.topic: conceptual
ms.collection: get-started
ms.date: 05/08/2023
ms.custom: bap-template
---

# Improve sequence efficiency with insights

Sequence insights provide valuable data on the performance of sequences and their steps. These insights enable organizations to identify areas that require improvement and take corrective measures to optimize their processes for intended results.

Also, by analyzing sequence insights data, organizations  can identify successful best practices that are working well across the sales team. Depending on the best practices, 
they can streamline their processes through common patterns and strategies that contribute to their success.

>[!NOTE]
>- By default, sequence insights are available in your organization from version 9.2.21051.001 or later.
>- After the sequence insights feature is available in your organization, any newly created or updated sequences display insights data.   
>- Sequences that are active before the feature availability don't display insights data. To get insights data for these sequences, you must reactivate them.

## Prerequisites

Ensure that sequences are configured and implemented in your organization. More information: [Sequences in sales accelerator](create-manage-sequences.md)

## View and understand sequence insights

To view sequence insights, open an active sequence. The sequence opens a Sankey diagram in a designer that illustrates the number of records that passed through each step of the process. 

This is an easy way to view the overall performance of the sequence. Moreover, you can identify steps in the sequence where a greater number of records are getting stuck or leaving from the sequence. 

By default, the data is displayed for the entire duration that the sequence has been active. However, you can filter the data for a specific duration such as last 7 days. Select **All data** at the top-right corner of the page.

The following image is an example of a sequence with insights displayed on the right pane 

:::image type="content" source="media/si-insights-phone-call.png" alt-text="Sequence flow diagram with insights for a phone call step" lightbox="media/si-insights-phone-call-exp.png":::

Select a step to get insights on how sellers are executing that step. 

The first step always displays the overall insights of the sequence. You can view the following data:
-	Total number of records that have flown into the sequence including the number of records that are currently being processed and those that have already been processed.
-	The maximum number of steps taken to process the sequence and the average number of days it took to complete the sequence. 
-	Understand the reasons why the sequence is disconnected from the records. The number listed below each reason indicates how many records were disconnected for each corresponding reason. For example, a sequence gets disconnected from a record when a seller completes the sequence. 

For other steps, a detailed analysis of each step is displayed.
-	Total number of records that have flown into the sequence including the number of records that are currently being processed and those that have already been processed.
-	Analyze step-specific actions that are performed by records, as these actions may vary for each step. For example, in the phone call step, basic actions that can be performed are making and receiving calls. Here, each action shows the number of records that have performed the action. 
-	Step status shows the number of records that are in different states such as, completed, skipped, and in-progress.
-	Understand the reasons why the sequence is disconnected from the records. The number listed below each reason indicates how many records were disconnected for each corresponding reason.
-	Know the time taken for each record to complete the step.

>[!NOTE]
>The analytics is not available for condition steps.

### See also

[Create and connect sequences for yourself](create-sequence-seller.md)  
[View and understand sales acceleration reporting](understand-sales-acceleration-reporting.md)  
[Understand the sequence stats page](understand-sequence-stats.md)

