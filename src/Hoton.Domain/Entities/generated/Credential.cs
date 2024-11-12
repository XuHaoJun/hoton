﻿using System;
using System.Collections.Generic;

namespace Hoton.Domain.Entities.generated;

public partial class Credential
{
    public string Id { get; set; }

    public byte[] Salt { get; set; }

    public string Type { get; set; }

    public string UserId { get; set; }

    public long? CreatedDate { get; set; }

    public string UserLabel { get; set; }

    public string SecretData { get; set; }

    public string CredentialData { get; set; }

    public int? Priority { get; set; }

    public virtual UserEntity User { get; set; }
}
