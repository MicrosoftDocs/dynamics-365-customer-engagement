---
title: DimSubject table reference
description: Learn about case subject hierarchy columns, source behavior, and the detail-only reporting scope of DimSubject.
ms.date: 10/30/2026
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ai-usage: ai-assisted
---

# DimSubject table reference

Use `DimSubject` to analyze case subjects and their configured parent-child hierarchy.

## Business value

The Dataverse subject tree classifies cases. Use the published table name `DimSubject`, not `DimCaseSubject`.

## Grain and source tables

The `subject` source supplies one row per `SubjectId`. When multiple versions exist, the latest `modifiedon` is retained. To build the root-first hierarchy, the pipeline follows up to six parent links.

## Columns

| Column | Type | Source or derivation | Description |
|---|---|---|---|
| `SubjectId` | STRING | `subject.subjectid`. | Primary key. |
| `SubjectName` | STRING | Trimmed `subject.title`. | Subject label. It is **(No Subject)** when the title is null. |
| `ParentSubjectId` | STRING | `subject.parentsubject`. | Parent subject ID. Value is null for a root subject. |
| `Description` | STRING | `subject.description`. | Source description, or null when unavailable. |
| `IsActive` | BOOLEAN | `subject.statecode = 0`. | Active flag. Defaults to true if the source has no `statecode`. |
| `SubjectLevel0` | STRING | Derived hierarchy. | Root label. |
| `SubjectLevel1` | STRING | Derived hierarchy. | Second-level label, when present. |
| `SubjectLevel2` | STRING | Derived hierarchy. | Third-level label, when present. |
| `SubjectLevel3` | STRING | Derived hierarchy. | Fourth-level label, when present. |
| `SubjectLevel4` | STRING | Derived hierarchy. | Fifth-level label, when present. |
| `SubjectLeaf` | STRING | Derived hierarchy. | Labels after the first five levels, joined with ` \| `. Null for shallower paths. |
| `SubjectHierarchy` | STRING | Derived hierarchy | Available hierarchy path, root first, joined with ` \| `. |
| `_LastRefreshedDateTimeUtc` | TIMESTAMP | System | Last data refresh date and time in UTC. |


## Reporting relationships

For detail analysis, create a single-direction, one-to-many relationship from `SubjectId` to `FactCase.SubjectId`.

The default dashboard doesn't import `DimSubject` or `FactCase`. None of the three aggregates, `AggCaseAnalytics`, `AggCaseSLA`, and `AggCaseSnapshot`, group by subject. Adding only this dimension doesn't let you filter their measures by subject.

## Related information

[Case analytics data model](case-data-model.md)
