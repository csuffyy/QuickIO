﻿// <copyright company="Benjamin Abt ( http://www.benjamin-abt.com - http://quickIO.NET )">
//      Copyright (c) 2016 Benjamin Abt Rights Reserved - DO NOT REMOVE OR EDIT COPYRIGHT
// </copyright>
// <author>Benjamin Abt</author>

using System;
using System.ComponentModel;
using System.Diagnostics.Contracts;

namespace SchwabenCode.QuickIO.Win32
{
    /// <summary>
    /// Win32 Error Code Collection
    /// </summary>
    public class Win32ErrorCodes
    {
        public const Int32 ERROR_ACCESS_DENIED = 5;
        public const Int32 ERROR_ADAP_HDW_ERR = 57;
        public const Int32 ERROR_ALREADY_ASSIGNED = 85;
        public const Int32 ERROR_ALREADY_EXISTS = 183;
        public const Int32 ERROR_ARENA_TRASHED = 7;
        public const Int32 ERROR_ATOMIC_LOCKS_NOT_SUPPORTED = 174;
        public const Int32 ERROR_AUTODATASEG_EXCEEDS_64k = 199;
        public const Int32 ERROR_BAD_ARGUMENTS = 160;
        public const Int32 ERROR_BAD_COMMAND = 22;
        public const Int32 ERROR_BAD_DEV_TYPE = 66;
        public const Int32 ERROR_BAD_DRIVER_LEVEL = 119;
        public const Int32 ERROR_BAD_ENVIRONMENT = 10;
        public const Int32 ERROR_BAD_EXE_FORMAT = 193;
        public const Int32 ERROR_BAD_FILE_TYPE = 222;
        public const Int32 ERROR_BAD_FORMAT = 11;
        public const Int32 ERROR_BAD_LENGTH = 24;
        public const Int32 ERROR_BAD_NET_NAME = 67;
        public const Int32 ERROR_BAD_NET_RESP = 58;
        public const Int32 ERROR_BAD_NETPATH = 53;
        public const Int32 ERROR_BAD_PATHNAME = 161;
        public const Int32 ERROR_BAD_PIPE = 230;
        public const Int32 ERROR_BAD_REM_ADAP = 60;
        public const Int32 ERROR_BAD_THREADID_ADDR = 159;
        public const Int32 ERROR_BAD_UNIT = 20;
        public const Int32 ERROR_BROKEN_PIPE = 109;
        public const Int32 ERROR_BUFFER_OVERFLOW = 111;
        public const Int32 ERROR_BUSY_DRIVE = 142;
        public const Int32 ERROR_BUSY = 170;
        public const Int32 ERROR_CALL_NOT_IMPLEMENTED = 120;
        public const Int32 ERROR_CANCEL_VIOLATION = 173;
        public const Int32 ERROR_CANNOT_COPY = 266;
        public const Int32 ERROR_CANNOT_MAKE = 82;
        public const Int32 ERROR_CHECKOUT_REQUIRED = 221;
        public const Int32 ERROR_CHILD_NOT_COMPLETE = 129;
        public const Int32 ERROR_CRC = 23;
        public const Int32 ERROR_CURRENT_DIRECTORY = 16;
        public const Int32 ERROR_DELETE_PENDING = 303;
        public const Int32 ERROR_DEV_NOT_EXIST = 55;
        public const Int32 ERROR_DIR_NOT_EMPTY = 145;
        public const Int32 ERROR_DIR_NOT_ROOT = 144;
        public const Int32 ERROR_DIRECT_ACCESS_HANDLE = 130;
        public const Int32 ERROR_DIRECTORY = 267;
        public const Int32 ERROR_DISCARDED = 157;
        public const Int32 ERROR_DISK_CHANGE = 107;
        public const Int32 ERROR_DISK_FULL = 112;
        public const Int32 ERROR_DISK_TOO_FRAGMENTED = 302;
        public const Int32 ERROR_DRIVE_LOCKED = 108;
        public const Int32 ERROR_DUP_NAME = 52;
        public const Int32 ERROR_DYNLINK_FROM_INVALID_RING = 196;
        public const Int32 ERROR_EA_FILE_CORRUPT = 276;
        public const Int32 ERROR_EA_LIST_INCONSISTENT = 255;
        public const Int32 ERROR_EA_TABLE_FULL = 277;
        public const Int32 ERROR_EAS_DIDNT_FIT = 275;
        public const Int32 ERROR_EAS_NOT_SUPPORTED = 282;
        public const Int32 ERROR_ENVVAR_NOT_FOUND = 203;
        public const Int32 ERROR_EXCL_SEM_ALREADY_OWNED = 101;
        public const Int32 ERROR_EXE_CANNOT_MODIFY_SIGNED_BINARY = 217;
        public const Int32 ERROR_EXE_CANNOT_MODIFY_STRONG_SIGNED_BINARY = 218;
        public const Int32 ERROR_EXE_MACHINE_TYPE_MISMATCH = 216;
        public const Int32 ERROR_EXE_MARKED_INVALID = 192;
        public const Int32 ERROR_FAIL_I24 = 83;
        public const Int32 ERROR_FAIL_NOACTION_REBOOT = 350;
        public const Int32 ERROR_FAIL_RESTART = 352;
        public const Int32 ERROR_FAIL_SHUTDOWN = 351;
        public const Int32 ERROR_FILE_CHECKED_OUT = 220;
        public const Int32 ERROR_FILE_EXISTS = 80;
        public const Int32 ERROR_FILE_NOT_FOUND = 2;
        public const Int32 ERROR_FILE_TOO_LARGE = 223;
        public const Int32 ERROR_FILENAME_EXCED_RANGE = 206;
        public const Int32 ERROR_FORMS_AUTH_REQUIRED = 224;
        public const Int32 ERROR_GEN_FAILURE = 31;
        public const Int32 ERROR_HANDLE_DISK_FULL = 39;
        public const Int32 ERROR_HANDLE_EOF = 38;
        public const Int32 ERROR_IMAGE_SUBSYSTEM_NOT_PRESENT = 308;
        public const Int32 ERROR_INCOMPATIBLE_WITH_GLOBAL_SHORT_NAME_REGISTRY_SETTING = 304;
        public const Int32 ERROR_INFLOOP_IN_RELOC_CHAIN = 202;
        public const Int32 ERROR_INSUFFICIENT_BUFFER = 122;
        public const Int32 ERROR_INVALID_ACCESS = 12;
        public const Int32 ERROR_INVALID_ADDRESS = 487;
        public const Int32 ERROR_INVALID_AT_INTERRUPT_TIME = 104;
        public const Int32 ERROR_INVALID_BLOCK = 9;
        public const Int32 ERROR_INVALID_CATEGORY = 117;
        public const Int32 ERROR_INVALID_DATA = 13;
        public const Int32 ERROR_INVALID_DRIVE = 15;
        public const Int32 ERROR_INVALID_EA_HANDLE = 278;
        public const Int32 ERROR_INVALID_EA_NAME = 254;
        public const Int32 ERROR_INVALID_EVENT_COUNT = 151;
        public const Int32 ERROR_INVALID_EXE_SIGNATURE = 191;
        public const Int32 ERROR_INVALID_FLAG_NUMBER = 186;
        public const Int32 ERROR_INVALID_FUNCTION = 1;
        public const Int32 ERROR_INVALID_HANDLE = 6;
        public const Int32 ERROR_INVALID_LEVEL = 124;
        public const Int32 ERROR_INVALID_LIST_FORMAT = 153;
        public const Int32 ERROR_INVALID_LOCK_RANGE = 307;
        public const Int32 ERROR_INVALID_MINALLOCSIZE = 195;
        public const Int32 ERROR_INVALID_MODULETYPE = 190;
        public const Int32 ERROR_INVALID_NAME = 123;
        public const Int32 ERROR_INVALID_OPLOCK_PROTOCOL = 301;
        public const Int32 ERROR_INVALID_ORDINAL = 182;
        public const Int32 ERROR_INVALID_PARAMETER = 87;
        public const Int32 ERROR_INVALID_PASSWORD = 86;
        public const Int32 ERROR_INVALID_SEGDPL = 198;
        public const Int32 ERROR_INVALID_SEGMENT_NUMBER = 180;
        public const Int32 ERROR_INVALID_SIGNAL_NUMBER = 209;
        public const Int32 ERROR_INVALID_STACKSEG = 189;
        public const Int32 ERROR_INVALID_STARTING_CODESEG = 188;
        public const Int32 ERROR_INVALID_TARGET_HANDLE = 114;
        public const Int32 ERROR_INVALID_VERIFY_SWITCH = 118;
        public const Int32 ERROR_IOPL_NOT_ENABLED = 197;
        public const Int32 ERROR_IS_JOIN_PATH = 147;
        public const Int32 ERROR_IS_JOIN_TARGET = 133;
        public const Int32 ERROR_IS_JOINED = 134;
        public const Int32 ERROR_IS_SUBST_PATH = 146;
        public const Int32 ERROR_IS_SUBST_TARGET = 149;
        public const Int32 ERROR_IS_SUBSTED = 135;
        public const Int32 ERROR_ITERATED_DATA_EXCEEDS_64k = 194;
        public const Int32 ERROR_JOIN_TO_JOIN = 138;
        public const Int32 ERROR_JOIN_TO_SUBST = 140;
        public const Int32 ERROR_LABEL_TOO_LONG = 154;
        public const Int32 ERROR_LOCK_FAILED = 167;
        public const Int32 ERROR_LOCK_VIOLATION = 33;
        public const Int32 ERROR_LOCKED = 212;
        public const Int32 ERROR_MAX_SESSIONS_REACHED = 353;
        public const Int32 ERROR_MAX_THRDS_REACHED = 164;
        public const Int32 ERROR_META_EXPANSION_TOO_LONG = 208;
        public const Int32 ERROR_MOD_NOT_FOUND = 126;
        public const Int32 ERROR_MORE_DATA = 234;
        public const Int32 ERROR_MR_MID_NOT_FOUND = 317;
        public const Int32 ERROR_NEGATIVE_SEEK = 131;
        public const Int32 ERROR_NESTING_NOT_ALLOWED = 215;
        public const Int32 ERROR_NET_WRITE_FAULT = 88;
        public const Int32 ERROR_NETNAME_DELETED = 64;
        public const Int32 ERROR_NETWORK_ACCESS_DENIED = 65;
        public const Int32 ERROR_NETWORK_BUSY = 54;
        public const Int32 ERROR_NO_DATA = 232;
        public const Int32 ERROR_NO_MORE_FILES = 18;
        public const Int32 ERROR_NO_MORE_ITEMS = 259;
        public const Int32 ERROR_NO_MORE_SEARCH_HANDLES = 113;
        public const Int32 ERROR_NO_PROC_SLOTS = 89;
        public const Int32 ERROR_NO_SIGNAL_SENT = 205;
        public const Int32 ERROR_NO_SPOOL_SPACE = 62;
        public const Int32 ERROR_NO_VOLUME_LABEL = 125;
        public const Int32 ERROR_NOT_DOS_DISK = 26;
        public const Int32 ERROR_NOT_ENOUGH_MEMORY = 8;
        public const Int32 ERROR_NOT_JOINED = 136;
        public const Int32 ERROR_NOT_LOCKED = 158;
        public const Int32 ERROR_NOT_OWNER = 288;
        public const Int32 ERROR_NOT_READY = 21;
        public const Int32 ERROR_NOT_SAME_DEVICE = 17;
        public const Int32 ERROR_NOT_SUBSTED = 137;
        public const Int32 ERROR_NOT_SUPPORTED = 50;
        public const Int32 ERROR_NOTIFICATION_GUID_ALREADY_DEFINED = 309;
        public const Int32 ERROR_OPEN_FAILED = 110;
        public const Int32 ERROR_OPLOCK_NOT_GRANTED = 300;
        public const Int32 ERROR_OUT_OF_PAPER = 28;
        public const Int32 ERROR_OUT_OF_STRUCTURES = 84;
        public const Int32 ERROR_OUTOFMEMORY = 14;
        public const Int32 ERROR_PARTIAL_COPY = 299;
        public const Int32 ERROR_PATH_BUSY = 148;
        public const Int32 ERROR_PATH_NOT_FOUND = 3;
        public const Int32 ERROR_PIPE_BUSY = 231;
        public const Int32 ERROR_PIPE_LOCAL = 229;
        public const Int32 ERROR_PIPE_NOT_CONNECTED = 233;
        public const Int32 ERROR_PRINT_CANCELLED = 63;
        public const Int32 ERROR_PRINTQ_FULL = 61;
        public const Int32 ERROR_PROC_NOT_FOUND = 127;
        public const Int32 ERROR_PROCESS_MODE_ALREADY_BACKGROUND = 402;
        public const Int32 ERROR_PROCESS_MODE_NOT_BACKGROUND = 403;
        public const Int32 ERROR_READ_FAULT = 30;
        public const Int32 ERROR_REDIR_PAUSED = 72;
        public const Int32 ERROR_RELOC_CHAIN_XEEDS_SEGLIM = 201;
        public const Int32 ERROR_REM_NOT_LIST = 51;
        public const Int32 ERROR_REQ_NOT_ACCEP = 71;
        public const Int32 ERROR_RING2_STACK_IN_USE = 207;
        public const Int32 ERROR_RING2SEG_MUST_BE_MOVABLE = 200;
        public const Int32 ERROR_SAME_DRIVE = 143;
        public const Int32 ERROR_SCOPE_NOT_FOUND = 318;
        public const Int32 ERROR_SECTOR_NOT_FOUND = 27;
        public const Int32 ERROR_SECURITY_STREAM_IS_INCONSISTENT = 306;
        public const Int32 ERROR_SEEK_ON_DEVICE = 132;
        public const Int32 ERROR_SEEK = 25;
        public const Int32 ERROR_SEM_IS_SET = 102;
        public const Int32 ERROR_SEM_NOT_FOUND = 187;
        public const Int32 ERROR_SEM_OWNER_DIED = 105;
        public const Int32 ERROR_SEM_TIMEOUT = 121;
        public const Int32 ERROR_SEM_USER_LIMIT = 106;
        public const Int32 ERROR_SHARING_BUFFER_EXCEEDED = 36;
        public const Int32 ERROR_SHARING_PAUSED = 70;
        public const Int32 ERROR_SHARING_VIOLATION = 32;
        public const Int32 ERROR_SHORT_NAMES_NOT_ENABLED_ON_VOLUME = 305;
        public const Int32 ERROR_SIGNAL_PENDING = 162;
        public const Int32 ERROR_SIGNAL_REFUSED = 156;
        public const Int32 ERROR_SUBST_TO_JOIN = 141;
        public const Int32 ERROR_SUBST_TO_SUBST = 139;
        public const Int32 ERROR_SUCCESS = 0;
        public const Int32 ERROR_SYSTEM_TRACE = 150;
        public const Int32 ERROR_THREAD_1_INACTIVE = 210;
        public const Int32 ERROR_THREAD_MODE_ALREADY_BACKGROUND = 400;
        public const Int32 ERROR_THREAD_MODE_NOT_BACKGROUND = 401;
        public const Int32 ERROR_TOO_MANY_CMDS = 56;
        public const Int32 ERROR_TOO_MANY_MODULES = 214;
        public const Int32 ERROR_TOO_MANY_MUXWAITERS = 152;
        public const Int32 ERROR_TOO_MANY_NAMES = 68;
        public const Int32 ERROR_TOO_MANY_OPEN_FILES = 4;
        public const Int32 ERROR_TOO_MANY_POSTS = 298;
        public const Int32 ERROR_TOO_MANY_SEM_REQUESTS = 103;
        public const Int32 ERROR_TOO_MANY_SEMAPHORES = 100;
        public const Int32 ERROR_TOO_MANY_SESS = 69;
        public const Int32 ERROR_TOO_MANY_TCBS = 155;
        public const Int32 ERROR_UNEXP_NET_ERR = 59;
        public const Int32 ERROR_VC_DISCONNECTED = 240;
        public const Int32 ERROR_VIRUS_DELETED = 226;
        public const Int32 ERROR_VIRUS_INFECTED = 225;
        public const Int32 ERROR_WAIT_NO_CHILDREN = 128;
        public const Int32 ERROR_WRITE_FAULT = 29;
        public const Int32 ERROR_WRITE_PROTECT = 19;
        public const Int32 ERROR_WRONG_DISK = 34;
        public const Int32 WAIT_TIMEOUT = 258;


        /// <summary>
        /// Exception Mapping
        /// </summary>
        /// <param name="path"></param>
        /// <param name="errorCode">errorCode</param>
        public static void NativeExceptionMapping( String path, Int32 errorCode )
        {
            Contract.Requires( !String.IsNullOrWhiteSpace( path ) );

            if( errorCode == Win32ErrorCodes.ERROR_SUCCESS )
            {
                return;
            }

            string affectedPath = path;

            // http://msdn.microsoft.com/en-us/library/windows/desktop/ms681382(v=vs.85).aspx

            switch( errorCode )
            {
                case Win32ErrorCodes.ERROR_PATH_NOT_FOUND:
                case Win32ErrorCodes.ERROR_FILE_NOT_FOUND:
                    throw new PathNotFoundException( Win32ErrorCodes.FormatMessage( errorCode ), affectedPath );

                case Win32ErrorCodes.ERROR_ALREADY_EXISTS:
                    throw new PathAlreadyExistsException( Win32ErrorCodes.FormatMessage( errorCode ), affectedPath );

                case Win32ErrorCodes.ERROR_INVALID_NAME:
                case Win32ErrorCodes.ERROR_DIRECTORY:
                    throw new InvalidPathException( Win32ErrorCodes.FormatMessage( errorCode ), affectedPath );

                case Win32ErrorCodes.ERROR_REM_NOT_LIST:
                case Win32ErrorCodes.ERROR_NETWORK_BUSY:
                case Win32ErrorCodes.ERROR_BUSY:
                case Win32ErrorCodes.ERROR_PATH_BUSY:
                    throw new FileSystemIsBusyException( Win32ErrorCodes.FormatMessage( errorCode ), affectedPath );

                case Win32ErrorCodes.ERROR_DIR_NOT_EMPTY:
                    throw new DirectoryNotEmptyException( Win32ErrorCodes.FormatMessage( errorCode ), affectedPath );

                case Win32ErrorCodes.ERROR_ACCESS_DENIED:
                case Win32ErrorCodes.ERROR_NETWORK_ACCESS_DENIED:
                    throw new UnauthorizedAccessException( "Access to '" + affectedPath + "' denied.", new Win32Exception( errorCode ) );

                case Win32ErrorCodes.ERROR_CURRENT_DIRECTORY:
                case Win32ErrorCodes.ERROR_CANNOT_MAKE:
                    throw new Exception( Win32ErrorCodes.FormatMessage( errorCode ) + affectedPath + "'.", new Win32Exception( errorCode ) );

                default:
                    throw new Exception( "Error on '" + affectedPath + "': See InnerException for details.", new Win32Exception( errorCode ) );
            }
        }

        /// <summary>
        /// Formats <paramref name="errorCode"/> to a message
        /// </summary>
        /// <param name="errorCode">ErrorCode</param>
        /// <returns>Message or "Unknown" if <paramref name="errorCode"/> is not handles</returns>
        public static string FormatMessage( Int32 errorCode )
        {
            switch ( errorCode )
            {
                case 0: return "The operation completed successfully.";
                case 1: return "Incorrect function.";
                case 10: return "The environment is incorrect.";
                case 100: return "Cannot create another system semaphore.";
                case 101: return "The exclusive semaphore is owned by another process.";
                case 102: return "The semaphore is set and cannot be closed.";
                case 103: return "The semaphore cannot be set again.";
                case 104: return "Cannot request exclusive semaphores at interrupt time.";
                case 105: return "The previous ownership of this semaphore has ended.";
                case 106: return "Insert the diskette for drive %1.";
                case 107: return "The program stopped because an alternate diskette was not inserted.";
                case 108: return "The disk is in use or locked by another process.";
                case 109: return "The pipe has been ended.";
                case 11: return "An attempt was made to load a program with an incorrect format.";
                case 110: return "The system cannot open the device or file specified.";
                case 111: return "The file name is too long.";
                case 112: return "There is not enough space on the disk.";
                case 113: return "No more internal file identifiers available.";
                case 114: return "The target internal file identifier is incorrect.";
                case 117: return "The IOCTL call made by the application program is not correct.";
                case 118: return "The verify-on-write switch parameter value is not correct.";
                case 119: return "The system does not support the command requested.";
                case 12: return "The access code is invalid.";
                case 120: return "This function is not supported on this system.";
                case 121: return "The semaphore timeout period has expired.";
                case 122: return "The data area passed to a system call is too small.";
                case 123: return "The filename, directory name, or volume label syntax is incorrect.";
                case 124: return "The system call level is not correct.";
                case 125: return "The disk has no volume label.";
                case 126: return "The specified module could not be found.";
                case 127: return "The specified procedure could not be found.";
                case 128: return "There are no child processes to wait for.";
                case 129: return "The %1 application cannot be run in Win32 mode.";
                case 13: return "The data is invalid.";
                case 130: return "Attempt to use a file handle to an open disk partition for an operation other than raw disk I/O.";
                case 131: return "An attempt was made to move the file pointer before the beginning of the file.";
                case 132: return "The file pointer cannot be set on the specified device or file.";
                case 133: return "A JOIN or SUBST command cannot be used for a drive that contains previously joined drives.";
                case 134: return "An attempt was made to use a JOIN or SUBST command on a drive that has already been joined.";
                case 135: return "An attempt was made to use a JOIN or SUBST command on a drive that has already been substituted.";
                case 136: return "The system tried to delete the JOIN of a drive that is not joined.";
                case 137: return "The system tried to delete the substitution of a drive that is not substituted.";
                case 138: return "The system tried to join a drive to a directory on a joined drive.";
                case 139: return "The system tried to substitute a drive to a directory on a substituted drive.";
                case 14: return "Not enough storage is available to complete this operation.";
                case 140: return "The system tried to join a drive to a directory on a substituted drive.";
                case 141: return "The system tried to SUBST a drive to a directory on a joined drive.";
                case 142: return "The system cannot perform a JOIN or SUBST at this time.";
                case 143: return "The system cannot join or substitute a drive to or for a directory on the same drive.";
                case 144: return "The directory is not a subdirectory of the root directory.";
                case 145: return "The directory is not empty.";
                case 146: return "The path specified is being used in a substitute.";
                case 147: return "Not enough resources are available to process this command.";
                case 148: return "The path specified cannot be used at this time.";
                case 149: return "An attempt was made to join or substitute a drive for which a directory on the drive is the target of a previous substitute.";
                case 15: return "The system cannot find the drive specified.";
                case 150: return "System trace information was not specified in your CONFIG.SYS file, or tracing is disallowed.";
                case 151: return "The number of specified semaphore events for DosMuxSemWait is not correct.";
                case 152: return "DosMuxSemWait did not execute; too many semaphores are already set.";
                case 153: return "The DosMuxSemWait list is not correct.";
                case 154: return "The volume label you entered exceeds the label character limit of the target file system.";
                case 155: return "Cannot create another thread.";
                case 156: return "The recipient process has refused the signal.";
                case 157: return "The segment is already discarded and cannot be locked.";
                case 158: return "The segment is already unlocked.";
                case 159: return "The address for the thread ID is not correct.";
                case 16: return "The directory cannot be removed.";
                case 160: return "One or more arguments are not correct.";
                case 161: return "The specified path is invalid.";
                case 162: return "A signal is already pending.";
                case 164: return "No more threads can be created in the system.";
                case 167: return "Unable to lock a region of a file.";
                case 17: return "The system cannot move the file to a different disk drive.";
                case 170: return "The requested resource is in use.";
                case 173: return "A lock request was not outstanding for the supplied cancel region.";
                case 174: return "The file system does not support atomic changes to the lock type.";
                case 18: return "There are no more files.";
                case 180: return "The system detected a segment number that was not correct.";
                case 182: return "The operating system cannot run %1.";
                case 183: return "Cannot create a file when that file already exists.";
                case 186: return "The flag passed is not correct.";
                case 187: return "The specified system semaphore name was not found.";
                case 188: return "The operating system cannot run %1.";
                case 189: return "The operating system cannot run %1.";
                case 19: return "The media is write protected.";
                case 190: return "The operating system cannot run %1.";
                case 191: return "Cannot run %1 in Win32 mode.";
                case 192: return "The operating system cannot run %1.";
                case 193: return "is not a valid Win32 application.";
                case 194: return "The operating system cannot run %1.";
                case 195: return "The operating system cannot run %1.";
                case 196: return "The operating system cannot run this application program.";
                case 197: return "The operating system is not presently configured to run this application.";
                case 198: return "The operating system cannot run %1.";
                case 199: return "The operating system cannot run this application program.";
                case 2: return "The system cannot find the file specified.";
                case 20: return "The system cannot find the device specified.";
                case 200: return "The code segment cannot be greater than or equal to 64K.";
                case 201: return "The operating system cannot run %1.";
                case 202: return "The operating system cannot run %1.";
                case 203: return "The system could not find the environment option that was entered.";
                case 205: return "No process in the command subtree has a signal handler.";
                case 206: return "The filename or extension is too long.";
                case 207: return "The ring 2 stack is in use.";
                case 208: return "The global filename characters, * or ?, are entered incorrectly or too many global filename characters are specified.";
                case 209: return "The signal being posted is not correct.";
                case 21: return "The device is not ready.";
                case 210: return "The signal handler cannot be set.";
                case 212: return "The segment is locked and cannot be reallocated.";
                case 214: return "Too many dynamic-link modules are attached to this program or dynamic-link module.";
                case 215: return "Cannot nest calls to LoadModule.";
                case 216: return "The version of %1 is not compatible with the version you're running. Check your computer's system information to see whether you need a x86 ; or x64 ; version of the program, and then contact the software publisher.";
                case 217: return "The image file %1 is signed, unable to modify.";
                case 218: return "The image file %1 is strong signed, unable to modify.";
                case 22: return "The device does not recognize the command.";
                case 220: return "This file is checked out or locked for editing by another user.";
                case 221: return "The file must be checked out before saving changes.";
                case 222: return "The file type being saved or retrieved has been blocked.";
                case 223: return "The file size exceeds the limit allowed and cannot be saved.";
                case 224: return "Access Denied. Before opening files in this location, you must first add the web site to your trusted sites list, browse to the web site, and select the option to login automatically.";
                case 225: return "Operation did not complete successfully because the file contains a virus.";
                case 226: return "This file contains a virus and cannot be opened. Due to the nature of this virus, the file has been removed from this location.";
                case 229: return "The pipe is local.";
                case 23: return "Data error ;.";
                case 230: return "The pipe state is invalid.";
                case 231: return "PathMatchAll pipe instances are busy.";
                case 232: return "The pipe is being closed.";
                case 233: return "No process is on the other end of the pipe.";
                case 234: return "More data is available.";
                case 24: return "The program issued a command but the command length is incorrect.";
                case 240: return "The session was canceled.";
                case 25: return "The drive cannot locate a specific area or track on the disk.";
                case 254: return "The specified extended attribute name was invalid.";
                case 255: return "The extended attributes are inconsistent.";
                case 258: return "The wait operation timed out.";
                case 259: return "No more data is available.";
                case 26: return "The specified disk or diskette cannot be accessed.";
                case 266: return "The copy functions cannot be used.";
                case 267: return "The directory name is invalid.";
                case 27: return "The drive cannot find the sector requested.";
                case 275: return "The extended attributes did not fit in the buffer.";
                case 276: return "The extended attribute file on the mounted file system is corrupt.";
                case 277: return "The extended attribute table file is full.";
                case 278: return "The specified extended attribute handle is invalid.";
                case 28: return "The printer is out of paper.";
                case 282: return "The mounted file system does not support extended attributes.";
                case 288: return "Attempt to release mutex not owned by caller.";
                case 29: return "The system cannot write to the specified device.";
                case 298: return "Too many posts were made to a semaphore.";
                case 299: return "Only part of a ReadProcessMemory or WriteProcessMemory request was completed.";
                case 3: return "The system cannot find the path specified.";
                case 30: return "The system cannot read from the specified device.";
                case 300: return "The oplock request is denied.";
                case 301: return "An invalid oplock acknowledgment was received by the system.";
                case 302: return "The volume is too fragmented to complete this operation.";
                case 303: return "The file cannot be opened because it is in the process of being deleted.";
                case 304: return "Short name settings may not be changed on this volume due to the global registry setting.";
                case 305: return "Short names are not enabled on this volume.";
                case 306: return "The security stream for the given volume is in an inconsistent state. Please run CHKDSK on the volume.";
                case 307: return "A requested file lock operation cannot be processed due to an invalid byte range.";
                case 308: return "The subsystem needed to support the image type is not present.";
                case 309: return "The specified file already has a notification GUID associated with it.";
                case 31: return "A device attached to the system is not functioning.";
                case 317: return "The system cannot find message text for message number 0x%1 in the message file for %2.";
                case 318: return "The scope specified was not found.";
                case 32: return "The process cannot access the file because it is being used by another process.";
                case 33: return "The process cannot access the file because another process has locked a portion of the file.";
                case 34: return "The wrong diskette is in the drive. Insert %2 ; into drive %1.";
                case 350: return "No action was taken as a system reboot is required.";
                case 351: return "The shutdown operation failed.";
                case 352: return "The restart operation failed.";
                case 353: return "The maximum number of sessions has been reached.";
                case 36: return "Too many files opened for sharing.";
                case 38: return "Reached the end of the file.";
                case 39: return "The disk is full.";
                case 4: return "The system cannot open the file.";
                case 400: return "The thread is already in background processing mode.";
                case 401: return "The thread is not in background processing mode.";
                case 402: return "The process is already in background processing mode.";
                case 403: return "The process is not in background processing mode.";
                case 487: return "Attempt to access invalid address.";
                case 5: return "Access is denied.";
                case 50: return "The request is not supported.";
                case 51: return "Windows cannot find the network path. Verify that the network path is correct and the destination computer is not busy or turned off. If Windows still cannot find the network path, contact your network administrator.";
                case 52: return "You were not connected because a duplicate name exists on the network. If joining a domain, go to System in Control Panel to change the computer name and try again. If joining a workgroup, choose another workgroup name.";
                case 53: return "The network path was not found.";
                case 54: return "The network is busy.";
                case 55: return "The specified network resource or device is no longer available.";
                case 56: return "The network BIOS command limit has been reached.";
                case 57: return "A network adapter hardware error occurred.";
                case 58: return "The specified server cannot perform the requested operation.";
                case 59: return "An unexpected network error occurred.";
                case 6: return "The handle is invalid.";
                case 60: return "The remote adapter is not compatible.";
                case 61: return "The printer queue is full.";
                case 62: return "Space to store the file waiting to be printed is not available on the server.";
                case 63: return "Your file waiting to be printed was deleted.";
                case 64: return "The specified network name is no longer available.";
                case 65: return "Network access is denied.";
                case 66: return "The network resource type is not correct.";
                case 67: return "The network name cannot be found.";
                case 68: return "The name limit for the local computer network adapter card was exceeded.";
                case 69: return "The network BIOS session limit was exceeded.";
                case 7: return "The storage control blocks were destroyed.";
                case 70: return "The remote server has been paused or is in the process of being started.";
                case 71: return "No more connections can be made to this remote computer at this time because there are already as many connections as the computer can accept.";
                case 72: return "The specified printer or disk device has been paused.";
                case 8: return "Not enough storage is available to process this command.";
                case 80: return "The file exists.";
                case 82: return "The directory or file cannot be created.";
                case 83: return "Fail on INT 24.";
                case 84: return "Storage to process this request is not available.";
                case 85: return "The local device name is already in use.";
                case 86: return "The specified network password is not correct.";
                case 87: return "The parameter is incorrect.";
                case 88: return "A write fault occurred on the network.";
                case 89: return "The system cannot start another process at this time.";
                case 9: return "The storage control block address is invalid.";

                default: return "unknown.";
            }
        }
    }
}
