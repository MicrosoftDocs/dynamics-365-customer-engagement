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

With AI-powered form fill assistance feature in Dynamics 365 Sales, you can streamline data entry in main and quick create forms. When this feature is enabled, you receive AI-generated suggestions for populating form fields, along with the source of the suggestions.

Suggestions are provided based on the following sources: 

- By analyzing your interactions within the app, existing form data, and your frequently used information.
- By extracting relevant details from text you paste using the Smart paste (Preview) feature.
- By identifying information from files you upload through the Files (Preview) feature.

These AI-generated suggestions help you fill forms more quickly and accurately. Suggestions are optional and will only be applied if you review and accept them. Learn more about [using AI-powered form fill assistance](/power-apps/user/form-filling-assistance).

## Use smart paste (preview)

Smart paste is an AI-assisted data entry feature that analyzes the content on your clipboard and suggests values for relevant fields in your CRM form. It intelligently detects names, email addresses, company details, phone numbers, and more, and maps them to the correct fields, saving you from typing everything manually. For information about prerequisites and limitation, see [AI-powered form fill assistance](/power-apps/user/form-filling-assistance).
 
To use Smart Paste (Preview):

1. Copy text or images from an email, business card, website, or any source that includes lead or contact information. 

1. Select the **Smart paste** icon (:::image type="icon" source="media/smart-paste.png" border="false":::) on your form, or use the keyboard shortcut Ctrl + V (Windows) or Cmd + V (Mac) when no specific field is selected. Smart paste will reason over both your form and clipboard content to generate AI-based suggestions.
   The system highlights suggested field values inline. 
1. Review the suggestions and choose to:
    - Accept all or individual suggestions.
    - Ignore suggestions you don’t want to use.
    - Manually edit or refine any field before saving.


## Use files (preview)

Files (Preview) is an AI-assisted data entry feature that analyzes uploaded files and suggests values for relevant fields in your CRM form. It can extract information from various file types, such as business cards or documents, and map them to the correct fields, saving you time and effort. For information about prerequisites and limitation, see [AI-powered form fill assistance](/power-apps/user/form-filling-assistance).

To use Files (Preview):

1. On a Dynamics 365 Sales form, drop the file you want to upload onto the form, or select the **+** icon to browse and upload the file.
   The system analyzes the file, extracts relevant information, and populates the form fields with suggested values.
1. Review the suggestions and choose to:
    - Accept all or individual suggestions.
    - Ignore suggestions you don’t want to use.
    - Manually edit or refine any field before saving.

## Example scenarios

Here are some real-world scenarios where AI-powered form fill assistance can significantly improve your productivity and data accuracy:

### Auto fill scenarios

Reduce repetitive data entry and ensure consistency when creating records based on existing customer relationships and historical data.

- **Following up on existing accounts:** When a sales rep creates a new opportunity for an existing customer like Contoso Ltd., AI automatically suggests the account name, primary contact, territory, and currency based on previous opportunities and account history. This eliminates manual lookup time and prevents data entry errors.

- **Creating related records:** When adding a new contact for a company already in your system, AI suggests the parent account, office location, and other company-specific details, ensuring data consistency across all related records.

- **Recurring business patterns:** For subscription-based businesses or repeat customers, AI recognizes patterns and suggests opportunity values like deal size, expected close dates, and sales stages based on similar historical deals with the same customer type.

### Files (preview) scenarios

Eliminate manual transcription from physical documents and reduce errors when digitizing business information from various file formats.

- **Trade show lead capture:** After collecting dozens of business cards at a trade show, a sales rep can quickly upload photos of business cards to create contact records. AI extracts names, job titles, company names, phone numbers, and email addresses, turning hours of manual data entry into minutes of review and confirmation.

- **Processing incoming resumes:** When hiring managers share candidate resumes via email, sales recruiters can upload PDF resumes to create contact records. AI identifies candidate names, current companies, job titles, and contact information, streamlining the recruitment pipeline setup.

- **Document-based lead generation:** When prospects send company brochures or proposal documents, AI can extract key business information like company details, decision-maker names, and contact information to create comprehensive lead records without manual typing.

### Smart paste (preview) scenarios

Transform unstructured information from emails, websites, and documents into structured CRM data, saving time and improving data capture accuracy.

- **Email-to-lead conversion:** A sales rep receives an inquiry email saying "Hi, I'm John Smith from Fabrikam Corp. We're looking for a CRM solution. You can reach me at john.smith\@fabrikam.com or 555-123-4567." By copying this text and using smart paste in a new lead form, AI automatically populates the name, company, email, and phone fields.

- **Web research data entry:** While researching a prospect's website, a sales rep copies the "About Us" or "Contact" page content. When creating a new account or lead record, smart paste analyzes the copied text and suggests values for company description, industry, key personnel names, and contact information.

- **LinkedIn profile information:** After viewing a prospect's LinkedIn profile, a sales rep can copy their experience section. Smart paste intelligently extracts current job title, company name, and work history to populate contact and account fields, ensuring up-to-date professional information.

- **Meeting notes transcription:** Following a discovery call, a sales rep copies notes like "Sarah mentioned they have 500 employees, annual revenue around $50M, currently using Salesforce, decision timeline is Q2 next year." Smart paste can extract and suggest values for employee count, revenue, competitor information, and timeline fields in the opportunity record.
