using JLookDataMigration.Models;
using Netcorext.EntityFramework.UserIdentityPattern.Entities;

namespace JLookDataMigration;

public static class Setting
{
    // v2 localhost
    // public const string NEW_FORUM_CONNECTION_LOCAL = "Host=127.0.0.1;Port=5432;Username=postgres;Password=P@ssw0rd;Database=lctech_jkf_forum_tttt;Timeout=1024;CommandTimeout=1800;Maximum Pool Size=80;";
    
    // v1 dev
    public const string OLD_FORUM_CONNECTION = "Host=35.194.153.253;Port=3306;Username=testuser;Password=b5GbvjRKXhrXcuW;Database=newjk;Pooling=True;maximumpoolsize=80;default command timeout=300;TreatTinyAsBoolean=false;sslmode=none;";
    // v1 stage
    // public const string OLD_FORUM_CONNECTION = "Host=34.80.4.149;Port=3306;Username=migrationUser;Password=A|5~9R}Olfs}@)/M;Database=newjk;Pooling=True;maximumpoolsize=80;default command timeout=300;TreatTinyAsBoolean=false;sslmode=none;";
    
    //v2 dev
    private const string HOST = "104.199.140.32";
    private const string USER_NAME = "postgres";
    private const string PASSWORD = "fybfe9-xaTdon-dozziw";
    
    //v2 stage
    // private const string HOST = "34.81.88.250";
    // private const string USER_NAME = "jkforum";
    // private const string PASSWORD = "5vvJumLnhFnu";
    
    private const string PORT = "5432";
    public const string NEW_LOOK_CONNECTION = $"Host={HOST};Port={PORT};Username={USER_NAME};Password={PASSWORD};Database=lctech_jlook;Timeout=1024;CommandTimeout=1800;Maximum Pool Size=80;SSL Mode=Require;Trust Server Certificate=true;Include Error Detail=true";

    public const string D = "";
    public const string INSERT_DATA_PATH = "../../../ScriptInsert";

    public const string COPY_ENTITY_SUFFIX = $",\"{nameof(Entity.CreationDate)}\",\"{nameof(Entity.CreatorId)}\",\"{nameof(Entity.ModificationDate)}\",\"{nameof(Entity.ModifierId)}\",\"{nameof(Entity.Version)}\") " +
                                             $"FROM STDIN (DELIMITER '{D}')\n";

    public const string COPY_SUFFIX = $") FROM STDIN (DELIMITER '{D}')\n";

    public const string SCHEMA_PATH = "../../../ScriptSchema";
    public const string BEFORE_FILE_NAME = "BeforeCopy.sql";
    public const string AFTER_FILE_NAME = "AfterCopy.sql";
}