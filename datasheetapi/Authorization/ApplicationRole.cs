using System.ComponentModel.DataAnnotations;

namespace datasheetapi.Authorization;

public enum ApplicationRole
{
    /// <summary>
    /// For everyone not associated with the application.
    /// </summary>
    [Display(Name = "None")]
    None = 0,

    /// <summary>
    /// ...
    /// </summary>
    [Display(Name = "User")]
    User,

    /// <summary>
    /// ...
    /// </summary>
    [Display(Name = "ReadOnlyUser")]
    ReadOnlyUser,

    /// <summary>
    /// ...
    /// </summary>
    [Display(Name = "Admin")]
    Admin,
}
