﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
#if VALIDATE_MULTI_TARGET
using System.Diagnostics;
#endif
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.Text;

namespace Microsoft.VisualStudio.LanguageServer.ContainedLanguage;

public abstract class LSPDocumentSnapshot
{
    public abstract int Version { get; }

    public abstract Uri Uri { get; }

    public abstract ITextSnapshot Snapshot { get; }

    public abstract IReadOnlyList<VirtualDocumentSnapshot> VirtualDocuments { get; }

    public bool TryGetVirtualDocument<TVirtualDocument>([NotNullWhen(returnValue: true)] out TVirtualDocument? virtualDocument) where TVirtualDocument : VirtualDocumentSnapshot
    {
        virtualDocument = null;

        for (var i = 0; i < VirtualDocuments.Count; i++)
        {
            if (VirtualDocuments[i] is TVirtualDocument actualVirtualDocument)
            {
#if VALIDATE_MULTI_TARGET
                Debug.Assert(virtualDocument is null, "Found multiple virtual documents of the same type. Should call TryGetAllVirtualDocuments instead.");
#endif
                virtualDocument = actualVirtualDocument;
#if !VALIDATE_MULTI_TARGET
                return true;
#endif
            }
        }

        return virtualDocument is not null;
    }

    public bool TryGetAllVirtualDocuments<TVirtualDocument>([NotNullWhen(returnValue: true)] out TVirtualDocument[]? virtualDocuments) where TVirtualDocument : VirtualDocumentSnapshot
    {
        List<TVirtualDocument>? actualVirtualDocuments = null;

        for (var i = 0; i < VirtualDocuments.Count; i++)
        {
            if (VirtualDocuments[i] is TVirtualDocument actualVirtualDocument)
            {
                actualVirtualDocuments ??= new List<TVirtualDocument>();
                actualVirtualDocuments.Add(actualVirtualDocument);
            }
        }

        virtualDocuments = actualVirtualDocuments?.ToArray();
        return virtualDocuments is not null;
    }
}
