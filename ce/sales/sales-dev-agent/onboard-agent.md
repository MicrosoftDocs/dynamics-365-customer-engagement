---
title: Onboard the Sales Development agent (preview)
description: Learn how to onboard the Sales Development agent and configure it for your organization.
ms.date: 09/25/2026
ms.topic: overview
author: sbmjais
ms.author: shjais
ai-usage: ai-assisted
---

# Onboard the Sales Development agent (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

After you create the agent, it guides you through the configuration via Teams. You chat with the agent to configure four key areas: playbook, guidelines, product knowledge, and settings.

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

> [!NOTE]
> It might take several hours before the agent is ready to work. The agent contacts you with a Teams chat message once it's ready to interact with you. The agent ignores any interactions before it contacts you.

The agent asks you to confirm any change to the playbook and guidelines before it applies them to its configuration. You can test each change before you apply them to gain confidence in your changes.

> [!TIP]
> When you make changes to the playbook and guidelines, the agent saves them as a draft that you can test before making them permanent. Your changes don't affect customer outreach until you tell the agent to apply them. When you're done suggesting and testing your playbook and guideline draft changes, ensure to tell the agent to "apply" your changes so they become permanent.

## Agent configuration framework

Four key components shape your agent's behavior.

| Component | What it does | How to manage it |
|-----------|--------------|------------------|
| [Playbook](#define-the-playbook) | Defines your prospect progression. | Comes with defaults; customize through Teams chat. |
| [Guidelines](#set-guidelines) | Sets the communication tone and defines acceptable and unacceptable behaviors when engaging with prospects. | Modify through Teams chat as needed. |
| [Product knowledge](#provide-product-knowledge) | Documents and URLs that teach the agent about your products. | Upload directly in Teams chat. |
| [Settings](#configure-email-and-outreach-settings) | Controls timing, disclaimers, and unsubscribe options. | Modify language through Teams chat. |

> [!TIP]
> You can ask the agent anytime to see the currently configured (or draft) playbook and guidelines. Just ask!

## Define the playbook

The playbook defines how a sales prospect progresses from one stage to another (outreach -> qualification -> handoff). The stages themselves are fixed, but you control the rules that move a prospect forward.

When the Sales Development agent prompts you, you can:

- Use the default playbook (recommended for first time setup).
- Provide your own rules. For example, "move to qualification after the prospect replies to one of your emails."

You must confirm changes to the playbook by asking the agent to apply your changes before they affect customer outreach.

## Set guidelines

Guidelines define how the AI agent works and communicates at each stage. Guidelines cover things like phrasing outreach, responding to objections, and handling handoffs or escalations.

You can:

- Accept the default guidelines.
- Share sample outreach emails to help the agent learn your tone and voice.

For example, when you provide two sample outreach emails, the agent correctly identifies they represent the outreach stage, generates matching tone and behavior rules, and offers to apply similar rules to other stages like qualification or handoff.

You must confirm changes to the guidelines by asking the agent to apply your changes before they affect customer outreach.

## Provide product knowledge

Provide content that helps the agent represent your offering accurately.

What you can share with the agent:

- Product or service documentation (.docx, .pdf, .pptx, .txt).
- SharePoint or OneDrive-hosted files.
- Public web pages, like your product pages or case studies.

The agent supports URL crawling up to two link levels deep (maximum of 100 links per level).

After you upload a file, the agent provides status feedback in Teams chat to confirm whether it successfully ingested the content or encountered any issues.

- Success: "Got it. I'll treat this page as product knowledge."
- Can't process: "I can't view this file directly. Could you share a text summary or document version instead?"

> [!CAUTION]
> Changes to knowledge take effect immediately. For example, as soon as a document is uploaded, the agent uses it for customer outreach. You can't test changes to knowledge before they're applied.

> [!WARNING]
> The content you share with an agent, such as files, chat history, or emails, might be summarized or included in the agent's responses to other users, *even those individuals who don't originally have access to that content.* This risk applies regardless of sensitivity labels or permissions placed on the content. For more information, see [Understand how content is shared with agents in Microsoft 365](/microsoft-agent-365/share).

## Configure email and outreach settings

Customize how the Sales Development agent interacts with prospects through email. You can adjust:

- **Email cadence**: Number and timing of follow-ups.
- **Signature**: How the agent signs off messages.
- **Unsubscribe text**: Standard opt-out language.

You can use the default settings and change them later.

> [!IMPORTANT]
> Complete the steps in the order described in this article. Type *default* at every step to demonstrate and customize later during coaching.