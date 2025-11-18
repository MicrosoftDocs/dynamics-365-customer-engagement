---
title: Fill forms effortlessly with AI assistance
description: Learn how to use AI-powered form fill assistance to automatically populate fields and streamline data entry in Dynamics 365 Sales forms.
ms.date: 11/11/2025
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

With AI-powered form fill assistance feature in Dynamics 365 Sales, you can streamline data entry in main and quick create forms. When this feature is enabled, you receive AI-generated suggestions for populating form fields, along with the source of the suggestions. These suggestions help you fill forms quickly and accurately. Suggestions are optional and will only be applied after you review and accept them.

Suggestions are provided based on the following sources: 

- By analyzing your interactions within the app, existing form data, and your frequently used information.
- By extracting relevant details from text you paste using the Smart paste (Preview) feature.
- By identifying information from files you upload through the Files (Preview) feature.

These AI-generated suggestions are available to all model-driven apps in Dynamics 365, including the Sales Hub app and custom apps. Learn more about prerequisites, limitations, and using the AI-powered form fill assistance in the [Power Apps documentation](/power-apps/user/form-filling-assistance). The links in the following sections point to the specific sections in the Power Apps documentation that explain how to use each feature in model-driven apps.

## Use form fill assistance

Copilot assistance for filling forms generates suggestions for blank form fields in model-driven apps. Suggestions are generated only for the tab that is open. They're presented inline in the form. Suggestions are entirely optional and aren't saved in the app until you accept them. To learn more about a suggestion, hover over the field, and specifically hover over the information icon. This is a citation, and identifies the source of a specific suggestion, for example "Records you have updated recently" or "Clipboard". Learn more about using the feature in [Use form fill assistance](power-apps/user/form-filling-assistance#use-form-fill-assistance). 

## Use smart paste (preview)

Smart paste is an AI-assisted data entry feature that analyzes the content on your clipboard and suggests values for relevant fields in your CRM form. It intelligently detects names, email addresses, company details, phone numbers, and more, and maps them to the correct fields, saving you from typing everything manually.Copy relevant content: Copy text or images from an email, business card, website, or any source that includes lead or contact information.

Copy text or images from emails, business cards, websites, or any source that includes lead or contact information, and select the **Smart paste** icon (:::image type="icon" source="media/smart-paste.png" border="false":::) on your form with no specific field selected to get AI-based suggestions. Learn more about using the feature in [Use smart paste (Preview)](/power-apps/user/form-filling-assistance#use-smart-paste-preview).

## Use files (preview)

Files (Preview) is an AI-assisted data entry feature that analyzes uploaded files and suggests values for relevant fields in your CRM form. It can extract information from various file types, such as business cards or documents, and map them to the correct fields, saving you time and effort. Learn more about using the feature in [Use toolbar and files (Preview)](/power-apps/user/form-filling-assistance#use-toolbar-and-files-preview).

## Example scenarios

Here are some real-world scenarios where AI-powered form fill assistance can significantly improve your productivity and data accuracy:

### Auto fill scenarios

Reduce repetitive data entry and ensure consistency when creating records based on existing customer relationships and historical data.

- **Following up on existing accounts:** When a sales rep creates a new opportunity for an existing customer like Contoso Ltd., AI automatically suggests the account name, primary contact, territory, and currency based on previous opportunities and account history. This eliminates manual lookup time and prevents data entry errors.

- **Creating related records:** When adding a new contact for a company already in your system, AI suggests the parent account, office location, and other company-specific details, ensuring data consistency across all related records.

### Smart paste (preview) scenarios

Transform unstructured information from emails, websites, and documents into structured CRM data, saving time and improving data capture accuracy.

- **Email-to-lead conversion:** A sales rep receives an inquiry email saying "Hi, I'm John Smith from Fabrikam Corp. We're looking for a CRM solution. You can reach me at john.smith@fabrikam.com or 555-123-4567." By copying this text and using smart paste in a new lead form, AI automatically populates the name, company, email, and phone fields.

- **Web research data entry:** While researching a prospect's website, a sales rep copies the "About Us" or "Contact" page content. When creating a new account or lead record, smart paste analyzes the copied text and suggests values for company description, industry, key personnel names, and contact information.

- **LinkedIn profile information:** After viewing a prospect's LinkedIn profile, a sales rep can copy their experience section. Smart paste intelligently extracts current job title, company name, and work history to populate contact and account fields, ensuring up-to-date professional information.

### Files (preview) scenarios

Eliminate manual transcription from physical documents and reduce errors when digitizing business information from various file formats.

- **Trade show lead capture:** After collecting dozens of business cards at a trade show, a sales rep can quickly upload photos of business cards to create contact records. AI extracts names, job titles, company names, phone numbers, and email addresses, turning hours of manual data entry into minutes of review and confirmation.

- **Document-based lead generation:** When prospects send company brochures or proposal documents, AI can extract key business information like company details, decision-maker names, and contact information to create comprehensive lead records without manual typing.


