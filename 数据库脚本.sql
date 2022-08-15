/*==============================================================*/
/* Database name:  Spotify                                      */
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     2022-4-25 15:03:22                           */
/*==============================================================*/

/*==============================================================*/
/* Database: Spotify                                            */
/*==============================================================*/
use master
drop database if exists Spotify
go
create database Spotify
go
use Spotify
go

/*==============================================================*/
/* Table: Album                                                 */
/*==============================================================*/
create table Album (
   AlbumId              int                  identity,
   AlbumName            nvarchar(50)         not null,
   Languages            nvarchar(20)         not null,
   Cover                nvarchar(50)         not null,
   GenreId              int                  null,
   SingerId             int                  not null,
   Publisher            nvarchar(50)         null,
   CopyrightOwner       nvarchar(50)         null,
   AlbumContent         text                 null,
   Price                decimal(18,2)        null,

   constraint PK_ALBUM primary key (AlbumId)
)
go

/*==============================================================*/
/* Table: Authority                                             */
/*==============================================================*/
create table Authority (
   AuthorityId          int                  identity,
   IdentityId           int                  not null,
   OperationId          int                  not null,
   ResourcesId          int                  not null,
   Authority            nchar(3)             not null
      constraint CKC_AUTHORITY_AUTHORIT check (Authority='未授权' or Authority='已授权'),
   constraint PK_AUTHORITY primary key (AuthorityId)
)
go

/*==============================================================*/
/* Table: Genre                                                 */
/*==============================================================*/
create table Genre (
   GenreId              int                  identity,
   EnglishName          nvarchar(10)         null,
   ChineseName          nvarchar(10)         null,
   GenreContent         text                 null,
   constraint PK_GENRE primary key (GenreId)
)
go

/*==============================================================*/
/* Table: "Identity"                                            */
/*==============================================================*/
create table "Identity" (
   IdentityId           int                  identity,
   IdentityName         nvarchar(50)         not null,
   constraint PK_IDENTITY primary key (IdentityId)
)
go

/*==============================================================*/
/* Table: Music                                                 */
/*==============================================================*/
create table Music (
   MusicId              nvarchar(50)         not null,
   MusicName            nvarchar(50)         not null,
   MusicTypeId          int                  not null,
   AlbumId              int                  not null,
   GenreId              int                  null,
   SingerId             int                  not null,
   Cover                nvarchar(50)         null,
   Duration             time                 not null,
   Lyricist             nvarchar(50)         null,
   Composer             nvarchar(50)         null,
   Arranger             nvarchar(50)         null,
   Producer             nvarchar(50)         null,
   Publisher            nvarchar(50)         null,
   CopyrightOwner       nvarchar(50)         null,
   Lyric                text                 null,
   ReleaseTime          date                 not null,
   Price                decimal(18,2)        null,
   VipMusic             nchar(1)             not null
      constraint CKC_VIPMUSIC_MUSIC check (VipMusic = '是' or VipMusic = '否'),
   Popularity           int                  not null,
   [Audit]            nvarchar(3)             not null
      constraint CKC_Audit check ([Audit] = '未过审' or [Audit] = '已过审'),
   constraint PK_MUSIC primary key (MusicId)
)
go

/*==============================================================*/
/* Table: MusicType                                             */
/*==============================================================*/
create table MusicType (
   TypeId               int                  identity,
   MusicId              nvarchar(50)         not null,
   TypeName             nvarchar(3)          not null
      constraint CKC_TYPENAME_MUSICTYP check (TypeName = '标准' or TypeName = '高品质' or TypeName = '无损'),
   Extension            nvarchar(20)         not null,
   MusicFile            text                 not null,
   constraint PK_MUSICTYPE primary key (TypeId)
)
go

/*==============================================================*/
/* Table: Operation                                             */
/*==============================================================*/
create table Operation (
   OperationId          int                  identity,
   OperationName        nvarchar(50)         not null,
   constraint PK_OPERATION primary key (OperationId)
)
go

/*==============================================================*/
/* Table: PlayList                                              */
/*==============================================================*/
create table PlayList (
   ListId               int                  identity,
   UserId               int                  not null,
   ListContent          text                 null,
   constraint PK_PLAYLIST primary key (ListId)
)
go

/*==============================================================*/
/* Table: PlayListDetails                                       */
/*==============================================================*/
create table PlayListDetails (
   DetailsId            int                  identity,
   ListId               int                  not null,
   MusicId              nvarchar(50)         not null,
   constraint PK_PLAYLISTDETAILS primary key (DetailsId)
)
go

/*==============================================================*/
/* Table: PlaybackRecord                                        */
/*==============================================================*/
create table PlaybackRecord (
   RecordId             int                  identity,
   MusicId              nvarchar(50)         not null,
   UserId               int                  not null,
   PlayTime             datetime             not null,
   constraint PK_PLAYBACKRECORD primary key (RecordId)
)
go

/*==============================================================*/
/* Table: Resources                                             */
/*==============================================================*/
create table Resources (
   ResourcesId          int                  identity,
   TableName            nvarchar(50)         not null,
   ChineseTableName     nvarchar(50)         not null,
   constraint PK_RESOURCES primary key (ResourcesId)
)
go

/*==============================================================*/
/* Table: Singer                                                */
/*==============================================================*/
create table Singer (
   SingerId             int                  identity,
   SingerName           nvarchar(50)         not null,
   Portrait             nvarchar(50)         not null,
   Cover                nvarchar(50)         not null,
   SingerContent        nvarchar(50)         null,
   UserId               int                  null,
   constraint PK_SINGER primary key (SingerId)
)
go

/*==============================================================*/
/* Table: "User"                                                */
/*==============================================================*/
create table "User" (
   UserId               int                  identity,
   UserName             nvarchar(20)         not null,
   Account              nvarchar(20)         not null,
   Password             nvarchar(20)         not null,
   Telephone            nchar(11)            not null,
   Signature            nvarchar(50)         null,
   Age                  int                  not null,
   Portrait             nvarchar(50)         null,
   IdentityId           int                  not null,
   constraint PK_USER primary key (UserId)
)
go

/*==============================================================*/
/* Table: VipRecord                                             */
/*==============================================================*/
create table VipRecord (
   RecordId             int                  identity,
   UserId               int                  not null,
   StartDate            date                 not null,
   EndDate              date                 not null,
   constraint PK_VIPRECORD primary key (RecordId)
)
go

/*==============================================================*/
/* Table: comment                                               */
/*==============================================================*/
create table comment (
   CommentId            int                  identity,
   AlbumId              int                  null,
   MusicId              nvarchar(50)         null,
   ListId               int                  null,
   UserId               int                  null,
   ReleaseDate          Date                 not null,
   Content              text                 null,
   likes                int                  not null,
   constraint PK_COMMENT primary key (CommentId)
)
go

alter table Album
   add constraint FK_ALBUM_REFERENCE_SINGER foreign key (SingerId)
      references Singer (SingerId)
go

alter table Album
   add constraint FK_ALBUM_REFERENCE_GENRE foreign key (GenreId)
      references Genre (GenreId)
go

alter table Authority
   add constraint FK_AUTHORIT_REFERENCE_IDENTITY foreign key (IdentityId)
      references "Identity" (IdentityId)
go

alter table Authority
   add constraint FK_AUTHORIT_REFERENCE_OPERATIO foreign key (OperationId)
      references Operation (OperationId)
go

alter table Authority
   add constraint FK_AUTHORIT_REFERENCE_RESOURCE foreign key (ResourcesId)
      references Resources (ResourcesId)
go

alter table Music
   add constraint FK_MUSIC_REFERENCE_ALBUM foreign key (AlbumId)
      references Album (AlbumId)
go

alter table Music
   add constraint FK_MUSIC_REFERENCE_SINGER foreign key (SingerId)
      references Singer (SingerId)
go

alter table Music
   add constraint FK_MUSIC_REFERENCE_GENRE foreign key (GenreId)
      references Genre (GenreId)
go

alter table MusicType
   add constraint FK_MUSICTYP_REFERENCE_MUSIC foreign key (MusicId)
      references Music (MusicId)
go

alter table PlayList
   add constraint FK_PLAYLIST_REFERENCE_USER foreign key (UserId)
      references "User" (UserId)
go

alter table PlayListDetails
   add constraint FK_PLAYLIST_REFERENCE_MUSIC foreign key (MusicId)
      references Music (MusicId)
go

alter table PlayListDetails
   add constraint FK_PLAYLIST_REFERENCE_PLAYLIST foreign key (ListId)
      references PlayList (ListId)
go

alter table PlaybackRecord
   add constraint FK_PLAYBACK_REFERENCE_MUSIC foreign key (MusicId)
      references Music (MusicId)
go

alter table PlaybackRecord
   add constraint FK_PLAYBACK_REFERENCE_USER foreign key (UserId)
      references "User" (UserId)
go

alter table Singer
   add constraint FK_SINGER_REFERENCE_USER foreign key (UserId)
      references "User" (UserId)
go

alter table VipRecord
   add constraint FK_VIPRECOR_REFERENCE_USER foreign key (UserId)
      references "User" (UserId)
go

alter table comment
   add constraint FK_COMMENT_REFERENCE_ALBUM foreign key (AlbumId)
      references Album (AlbumId)
go

alter table comment
   add constraint FK_COMMENT_REFERENCE_MUSIC foreign key (MusicId)
      references Music (MusicId)
go

alter table comment
   add constraint FK_COMMENT_REFERENCE_PLAYLIST foreign key (ListId)
      references PlayList (ListId)
go

alter table comment
   add constraint FK_COMMENT_REFERENCE_USER foreign key (UserId)
      references "User" (UserId)
go

