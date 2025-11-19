---
title: Fill forms effortlessly with AI assistance
description: Learn how to use AI-powered form fill assistance to automatically populate fields and streamline data entry in Dynamics 365 Sales forms.
ms.date: 11/19/2025
ms.update-cycle: 180-days
ms.topic: how-to
ms.service: dynamics-365-sales
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-description
  - ai-seo-date:11/11/2025
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Fill forms effortlessly with AI assistance

With the AI-powered form fill assistance feature in Dynamics 365 Sales, you can streamline data entry in main and quick create forms. When this feature is enabled, you receive AI-generated suggestions for populating form fields, along with the source of the suggestions. These suggestions help you fill forms quickly and accurately. Suggestions are optional and will only be applied after you review and accept them.

Suggestions are provided based on the following sources: 

- By analyzing your interactions within the app, existing form data, and your frequently used information.
- By extracting relevant details from text that you paste using the Smart paste (Preview) feature.
- By identifying information from files that you upload through the Files (Preview) feature.

These AI-generated suggestions are available to all model-driven apps, including the Sales Hub app and custom apps. Learn more about prerequisites, limitations, and using the AI-powered form fill assistance in the [Power Apps documentation](/power-apps/user/form-filling-assistance). 

The following screenshot illustrates the Form fill assist toolbar in a lead form in Dynamics 365 Sales.

:::image type="content" source="media/form-assists-toolbar.png" alt-text="Screenshot of the Form fill assist toolbar in a lead form in Dynamics 365 Sales.":::

> [!NOTE]
> Suggestions are generated only for a new form and for the tab that's open. For example, if you copied text related to industry, annual revenue, and number of employees, then open the **Details** tab in the lead form and select **Smart paste** to see the values populated for those fields.  

## Use form fill assistance

Copilot assistance for filling forms generates suggestions for blank form fields in model-driven apps. Suggestions are generated only for the tab that's open. They're presented inline in the form. Suggestions are entirely optional and aren't saved in the app until you accept them. To learn more about a suggestion, hover over the field, and specifically hover over the information icon. You'll see a citation that identifies the source of a specific suggestion such as "Records you have updated recently" or "Clipboard." Learn more about using the feature in [Use form fill assistance](/power-apps/user/form-filling-assistance#use-form-fill-assistance).

## Use smart paste (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner-section.md)]
[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]


Smart paste is an AI-assisted data entry feature that analyzes the content on your clipboard and suggests values for relevant fields in your CRM form. It intelligently detects names, email addresses, company details, phone numbers, and more, and maps them to the correct fields, saving you from typing everything manually. 

Copy text or images from emails, business cards, websites, or any source that includes lead or contact information, and select the **Smart paste** icon (:::image type="icon" source="media/smart-paste.png" border="false":::) on your form with no specific field selected to get AI-based suggestions. Learn more about using the feature in [Use smart paste (Preview)](/power-apps/user/form-filling-assistance#use-smart-paste-preview).

## Use files (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner-section.md)]
[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

Files (Preview) is an AI-assisted data entry feature that analyzes uploaded files and suggests values for relevant fields in your CRM form. It can extract information from various file types, such as business cards or documents, and map them to the correct fields, saving you time and effort. Learn more about using the feature in [Use toolbar and files (Preview)](/power-apps/user/form-filling-assistance#use-toolbar-and-files-preview).

Select the **Source upload** icon (:::image type="icon" source="media/source-upload-icon.png" border="false":::) on the form fill assist toolbar or drag and drop files onto the toolbar to upload files like images of business cards or documents containing lead or contact information. The AI analyzes the content of the uploaded files and suggests values for relevant fields in your form.

## Example scenarios

Here are some real-world scenarios where AI-powered form fill assistance can significantly improve your productivity and data accuracy:

### Auto fill scenarios

Reduce repetitive data entry and ensure consistency when creating records based on existing customer relationships and historical data.

- **Following up on existing accounts:** When you create a new opportunity for an existing customer like Contoso Ltd., AI automatically suggests the account name, primary contact, territory, and currency based on previous opportunities and account history. This feature eliminates manual lookup time and prevents data entry errors.

- **Creating related records:** When you add a new contact for a company already in your system, AI suggests the parent account, office location, and other company-specific details, ensuring data consistency across all related records.

### Smart paste (preview) scenarios

Transform unstructured information from emails, websites, and documents into structured CRM data, saving time and improving data capture accuracy.

- **Email-to-lead conversion:** You receive an inquiry email saying "Hi, I'm John Smith from Fabrikam Corp. We're looking for a CRM solution. You can reach me at john.smith@fabrikam.com or 555-123-4567." Copy this text and use smart paste in a new lead form to let AI extract and populate the relevant fields such as name, company, email, and phone number.

- **Web research data entry:** When you're researching a prospect's website, you copy the "About Us" or "Contact" page content. Use smart paste to automatically fill in fields in the lead or account form with company name, industry, location, and contact details.

- **LinkedIn profile information:** After viewing a prospect's LinkedIn profile, you can copy their experience section. Smart paste intelligently extracts current job title, company name, and work history to populate contact and account fields, ensuring up-to-date professional information.
### Files (preview) scenarios

Eliminate manual transcription from physical documents and reduce errors when digitizing business information from various file formats.

- **Trade show lead capture:** After collecting dozens of business cards at a trade show, you can quickly upload photos of business cards to create contact records. AI extracts names, job titles, company names, phone numbers, and email addresses, turning hours of manual data entry into minutes of review and confirmation.

- **Document-based lead generation:** When prospects send company brochures or proposal documents, AI can extract key business information like company details, decision-maker names, and contact information to create comprehensive lead records without manual typing.


