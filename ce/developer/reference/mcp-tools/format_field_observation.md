---
title: Prepare a field observation note (preview)
description: Prepare a proofread Field Service note for a Dynamics 365 record, review and edit it with one optional attachment, and save it only when you select Save.
ms.date: 11/23/2026
ms.topic: reference
ai-usage: ai-assisted
ms.custom: mcp-enabled-namespaces=field-service
ms.service: dynamics-365-field-service
author: jasonccohen
ms.author: jacoh
ms.reviewer: puneetsingh
---

# Prepare a field observation note (preview)

[!INCLUDE [public-preview-banner](../../../includes/public-preview-banner.md)]

**Applies to:** Dynamics 365 Field Service

Prepare an onsite observation, then review it before saving it to a work order, booking, or another record that supports notes.

[!INCLUDE [public-preview-note](../../../includes/public-preview-note.md)]

## Prerequisites

- Your security role must allow you to create, read, and append notes, read work orders, and read and add notes to the destination record.
- The destination record must support notes.
- Dataverse search helps find records when you don't name their type. If search is unavailable or incomplete, provide the record type and its name or number.

## Try prompts like

- Leave a note for WO-00123: furnace looks good except for rust on the left side. Replacement likely in six months.
- Add a note to my booking with Contoso Coffee that the gate code changed.
- Log a note on the Calibrate grinder task on WO-00004: readings within tolerance.
- Tidy up these notes before I log them: replaced corroded pipe section, pressure test passed.

## What you can do

1. Provide the note text and identify where it belongs. Include the record type, such as booking or service task, when possible.
2. Review the destination, factual title, and proofread text. Corrections cover clear typos, spelling, punctuation, and minor grammar, while preserving your wording, numbers, and uncertainty.
3. Select **Edit note** to change the title or text. Select **Done** to keep your edits or **Cancel** to discard them.
4. If several records match, choose the correct record and select **Select record**. Choosing a record doesn't save the note.
5. If needed, use **Capture media** or **Select from library** to add one supported attachment, within the size limit shown in the preview.

Provide note text first. An empty preview has no save or attachment controls. If the destination is uncertain, your note is kept while you provide more detail.

## Save and confirm changes

Preparing, editing, choosing a record, and attaching a file don't save the note. Select **Save** to create the note and upload its attachment.

Don't assume that saying "looks good" saves it. Saving through a later chat reply is optional and off by default; use **Save** for the standard workflow.

If the note was saved but the attachment failed, select **Retry attachment** instead of creating another note. If the result of saving the note itself can't be confirmed, check the destination record before trying again.

## Tips and limitations

- Ask to keep your text word for word if you don't want proofreading.
- Supported files include PNG, JPEG, GIF, and WebP images, PDF, plain text, Word, Excel, PowerPoint (.pptx), and ZIP. Video, audio, and HEIC aren't supported.
- Shorten the note if the preview says it exceeds the allowed length.
- To record a note together with task, part, or status changes, describe the work in one message to prepare a work progress plan.

## Related information

- [Capture work progress](capture_work_progress.md)
- [View a work order](get_work_order.md)
- [Update a note](update_note.md)
- [Configure Dataverse search](/power-platform/admin/configure-relevance-search-organization)
