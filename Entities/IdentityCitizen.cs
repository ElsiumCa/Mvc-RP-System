using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

public class IdentityCitizen : IdentityUser
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    // Doğum tarihi
    public string? JoinDate { get; set; }

    // Kullanıcının mesleği veya unvanı (örneğin: Başkan, Hakim, Çiftçi, Madenci vs.)
    public string? Occupation { get; set; }

    // Kullanıcının ana rolü (Citizen, President, Judge vs.)
    public string? MainRole { get; set; } = "Citizen";

    // Kullanıcının sahip olduğu ekstra roller (başkanlık, hakimlik gibi)
    public List<string>? SubRoles { get; set; } = new List<string>();

    // Suç kaydı varsa, liste halinde tutulabilir
    public List<string>? CriminalRecords { get; set; } = new List<string>();

    // Kullanıcının ceza puanı (belirli bir seviyeyi geçerse hapse atılabilir)
    public int? PenaltyPoints { get; set; }

    public List<String>? Lands { get; set; }


}
