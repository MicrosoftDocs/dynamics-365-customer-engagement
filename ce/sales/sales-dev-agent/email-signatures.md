---
title: Customize email signatures with images
description: Learn how to add contact information and a hosted image to your Sales Development agent's email signature, then test how it appears in an email.
ms.date: 11/11/2026
ms.topic: how-to
author: sbmjais
ms.author: shjais
ai-usage: ai-assisted
---

# Customize email signatures with images

Customize your Sales Development agent's email signature with contact information and a company logo or branded banner. In your one-to-one Microsoft Teams chat with the agent, provide an HTML signature and ask the agent to save it to its email signature setting.

This procedure changes the saved email signature, not the agent's playbook, guidelines, or product knowledge.

## Prepare your signature

Gather the following information before you update the signature:

- The name, company name, and email address you want to display.
- An image approved for external email, such as your company logo or a branded banner.
- A direct HTTPS URL for the image. Use a stable, organization-approved hosting location that recipients can access without signing in. Don't use a local file path, a link to a page that displays the image, or a sharing link that requires permission.
- Descriptive alternative text for the image, such as your company name followed by "logo".

The signature references the hosted image through an HTML `<img>` tag. Keep essential contact information as text so recipients can read it even when the image doesn't display.

## Update the saved email signature

Use the following placeholders to customize the example prompt:

| Placeholder | Replace with |
| --- | --- |
| `[name]` | The name you want to display in the signature. |
| `[company]` | Your company name. |
| `[email-address]` | Your email address, in both the `mailto:` link and the visible link text. |
| `[image-url]` | The full HTTPS URL of your approved image. |
| `[alt-text]` | A short description of the image. |

1. Open your one-to-one Teams chat with the Sales Development agent.
2. Copy the following prompt and replace each placeholder, including its brackets, with your signature details.

   ```text
   Update your saved email signature setting with the following HTML. Preserve the image tag and its URL exactly.

   <p><strong>[name]</strong><br>
   [company]<br>
   Email: <a href="mailto:[email-address]">[email-address]</a></p>
   <p><img src="[image-url]"
           alt="[alt-text]" width="360"></p>
   ```

3. Send the completed prompt to the agent. Include the HTML as text, not as a screenshot or image attachment.
4. Review the agent's response and complete any confirmation it requests. Verify that the agent confirms it updated the saved email signature setting, rather than only showing a proposed signature.

> [!TIP]
> The example uses `width="360"` to request an image width of 360 pixels. Adjust this value to suit your logo or banner.

## Test the email signature

Before you use the signature for prospect outreach, ask the agent to *Send a test email*. Follow your organization's testing process and review the email in an approved test mailbox.

Check the following conditions:

- The signature displays the correct name, company, and email address.
- The email address link opens a message addressed to the intended recipient.
- The logo or banner displays at an appropriate size.
- The signature is readable on desktop and mobile devices.
- Essential contact information remains readable when external images are blocked.

> [!NOTE]
> Some email clients block external images or display them differently. Saving the image URL in the signature doesn't guarantee that every recipient's email client automatically displays the image.

## Troubleshoot image display

| Issue | What to check |
| --- | --- |
| The image doesn't display. | Verify that the image URL is still available, points directly to an image, and doesn't require authentication. Check whether the recipient's email client blocks external images. |
| The saved signature is missing the image tag, or the URL changed. | Resend the prompt with the intended HTML and ask the agent to preserve the image tag and URL exactly. Then ask the agent to show the saved signature so you can verify it. |
| The image is too large or too small. | Adjust the `width` value in the HTML, ask the agent to save the updated signature, and review another test email. |
| The agent returns an example signature without saving it. | Ask the agent to apply the HTML to its saved email signature setting. Verify that it confirms the update. |

## Related information

- [Onboard the Sales Development agent](onboard-agent.md)
- [Sales Development agent overview](sales-development-agent-overview.md)
