---
title: Automate creation of multiple cases from emails
description: Automate creation of multiple cases from emails to improve customer service efficiency and response times.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: conceptual
ms.collection:
ms.date: 03/14/2024
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-title
  - ai-seo-date:03/14/2024
  - ai-gen-desc
---

# Automate creation of multiple cases from emails

At present, when an email is sent to multiple mailboxes (To, CC, or BCC) which are queue-enabled in Customer Service, the email gets converted to only one case using automatic record creation rules. Multiple cases aren’t created for an email sent to multiple mailboxes.

As an administrator, by enabling this feature, you can ensure that multiple cases (one for each queue-enabled mailbox) get created when multiple mailboxes are added as recipients in the email. With the ability to create multiple cases from an email, agents can do the following:

- With multiple cases being created, email appears in the timeline for all cases. So, agents can respond to customers’ issues independently.  

- Replies to the original email are linked to the appropriate cases.  

- Agents can see responses from the customer to outbound emails on the case timeline.

- When a customer replies to the original email adding a new queue-enabled mailbox or forwards the original email to a new queue-enabled mailbox, a new case gets created for that queue.

## Automatic record creation process flow 

After the feature is enabled, any new emails sent to multiple mailboxes get converted to multiple cases and a Related attribute (new attribute introduced on email activity to capture multiple records that an email can be associated with) is set for those cases. For more information on related attribute, see Enable users to associate activities to multiple records (preview). The existing Regarding attribute for such emails will be blank. However, once the feature is turned on, for any existing email records, you’ll see the following:

- If older email records have an existing Active case set as Regarding, no new case gets created when a reply email arrives even if a new mailbox is added. The replied email gets associated with an existing case and regarding is set to the existing active case. The Related field remains empty, as no case was created.  

- If older email records have an existing Resolved case set as Regarding, and the Wait for a specific amount of time after the connected case has been resolved option is set to YES, and a reply email arrives after the time mentioned in the Select the amount of time setting, a new case gets created. The new email populates the related attribute for the reply email. If the reply email is sent to multiple mailboxes, multiple cases get created and the related field gets populated with multiple cases. The Regarding field for the reply email is set to blank.

The following flowchart explains how automatic record creation rules work to create multiple cases from an email sent to multiple mailboxes.

:::image type="content" source="../media/arc_process_flow.png" alt-text="Screenshot of automatic record creation process flow":::

## Next steps

Enable creation of multiple cases from an email sent to multiple mailboxes