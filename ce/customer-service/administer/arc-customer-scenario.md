---
title: How the automatic record creation rule works in a customer scenario
description: Understand how automatic record creation rules work in customer scenarios and learn how to customize them.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: conceptual
ms.collection:
ms.date: 12/13/2024
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:03/14/2024
---


# How the automatic record creation rule works in a customer scenario

With automatic record creation, you can create multiple cases from an email sent to multiple mailboxes. As an administrator, you can [enable this feature](arc-multiple-cases.md#enable-creation-of-multiple-cases-from-an-email-sent-to-multiple-mailboxes) to ensure that [multiple cases (one for each queue-enabled mailbox) get created when multiple mailboxes are added as recipients in the email](arc-multiple-cases.md#how-automatic-record-creation-rules-work-to-create-multiple-cases-from-an-email-sent-to-multiple-mailboxes).

This topic lists the various customer scenarios and explains how the automatic record creation rule works when a customer sends a new email, replies to an email, or forwards a customer service representative's (service representative) email. The following flowchart explains the customer scenario.

:::image type="content" source="../media/arc_customer-scenario.png" alt-text="Flowchart explaining the customer scenario.":::

## Customer sends a new email

When a customer sends a new email (and the email isn’t a reply or forward to any previous email) to queue-enabled mailboxes (irrespective of the mailboxes being in To, Cc, or Bcc), automatic record creation rule creates cases for each mailbox.  

For example, if email E1 was sent to Q1, Q2, and Q3 mailboxes, which are configured as queues, three cases are created Case 1, Case 2, Case 3, which originated in queues Q1, Q2, and Q3, respectively. The original email E1 is related to all the three cases (Case 1, Case 2, and Case 3) and displayed in each case’s timeline.

## Customer replies to an email

### Replies to the original email from Sent items to same queue

When a customer replies (ER1) to the original email E1 from the Sent items folder to the same mailboxes (Q1, Q2, and Q3), the reply email is considered as a response to the original email (E1). The automatic record creation rule skips case creation. The reply email (ER1) is correlated with the original email E1 and displays on the timeline for all cases in which the original email E1 is linked (Case 1, Case 2, and Case 3).

### Replies to the original email from Sent items and adds a new queue

When a customer adds a new mailbox, Q4, to the already existing Q1, Q2, Q3 mailboxes in a replied email, the automatic record creation rule creates a new case, Case 4, for the additional mailbox Q4. The response email, ER1, is related to all cases: Case 1, Case 2, Case 3, and Case 4. The response email appears as a threaded response for Case 1, Case 2, and Case 3. Case 4 displays the response email, ER1.

### Replies to the original email from Sent items after removing a queue

When a customer replies to the original email E1 from the Sent items folder but removes the mailbox Q1 and only sends it to Q2 and Q3, the automatic record creation rule treats the reply email as a response to the original email, E1. Automatic record creation skips case creation for Q2 and Q3.

Out of the box, the response email, ER1, is related to all cases, Case 1, Case 2, and Case 3, since email correlation doesn’t break. As the original email was sent to all cases, the reply email is also sent to all cases, Case 1, Case 2, and Case 3, even though mailbox Q1 is removed from the reply email.  

We recommend using [customization](#customization) to ensure that the reply email isn’t related to the case that originated in the mailbox that was removed from the reply email. You’ll need to check for the correlated case that originated in the mailbox that was removed from the reply email, and remove the identified case from the replied email’s related attribute.

### Replies to a service representative’s email from Inbox to the same queue  

When a customer replies from the Inbox to the service representative’s outbound email sent from the Case 1 timeline (after removing other mailboxes Q2 and Q3), the automatic record creation rule skips the case creation, and the reply gets linked to Case 1 and all the existing cases that originated in Q2 and Q3, unless the service representative removes the cases that originated in the removed mailboxes Q2 and Q3, from the reply email’s related attribute before sending the outbound email to the customer. If you performed [timeline customization](arc-agent-scenario.md#timeline-customization), the service representative’s outbound email sent from the Case 1 timeline is associated with only Case 1, and the C2’s response to the service representative’s email is only associated with Case 1.  

### Replies to a service representative’s email from Inbox to a different queue

When a customer replies from the Inbox to the service representative’s outbound email sent from the Case 1 timeline, and adds a new queue, a new case gets created for that queue. The reply email is related to the existing cases that originated in the correlated email and the new case.

### Replies to a service representative’s email with the same queue on a closed case

If the **Wait for specific amount of time after the connected case has been resolved** toggle is set to **Yes** and the time configured in the setting hasn’t elapsed, no case gets created. If the time has elapsed, new cases are created for that queue.

## Customer forwards an email

### Forwards a service representative’s reply email to the same queue from Inbox

When a customer forwards an email from their Inbox to the same queues, the response is sent by the customer to the same queue. So, automatic record creation skips case creation.

### Forwards a service representative’s reply email to a new queue from Inbox

When a customer forwards the service representative’s reply mail from the Inbox to a new queue, automatic record creation creates a new case, Case 4, for Q4 (the new queue). Email is tagged to all cases that originated in the old queues and to the new Case 4 that was created.

However, if you don't want the forwarded email to be associated with the existing cases that originated in the earlier queues, you need to perform [customization](#customization).

### Forwards an original email to same queue from Sent Items

When a customer forwards the original email, E1, from Sent items to the same queue, automatic record creation skips case creation as the correlation still exists.

### Forwards the original email to a new queue from Sent Items

When a customer forwards the original email, E1, from Sent items to another queue, Q4, automatic record creation creates a new case, Case 4, for Q4. The forwarded email is related to all cases: Case 1, Case 2, Case 3, and Case 4.

However, if you don't want the forwarded email to be associated with the existing cases that originated in the earlier queues, you'll need to perform [customization](#customization).

## Customization

Developers can perform customization to ensure that:

- The reply email isn’t related to the case that originated in the mailbox but was removed from the reply email. Learn more in [Replies to the original email from Sent items after removing a queue](#replies-to-the-original-email-from-sent-items-after-removing-a-queue).
- The forwarded email isn't associated with the existing cases that originated in the earlier queues. Learn more in [Forwards a service representative’s reply email to a new queue from Inbox](#forwards-a-service-representatives-reply-email-to-a-new-queue-from-inbox) and [Forwards the original email to a new queue from Sent Items](#forwards-the-original-email-to-a-new-queue-from-sent-items).

Learn more about customization in [Sample - ARC Multi-Related - Remove Unreferenced Queue](sample-arc-multiple-cases.md#sample---arc-multi-related---remove-unreferenced-queue).

## Related information

[Create multiple cases from an email sent to multiple mailboxes](arc-multiple-cases.md#create-multiple-cases-from-an-email-sent-to-multiple-mailboxes)

[Enable creation of multiple cases from an email sent to multiple mailboxes](arc-multiple-cases.md#enable-creation-of-multiple-cases-from-an-email-sent-to-multiple-mailboxes)

[How the automatic record creation rule works in a service representative scenario](arc-agent-scenario.md#how-the-automatic-record-creation-rule-works-in-a-service-representative-scenario)
