using System;
using System.Collections.Generic;
using System.Text;

namespace WHC.Framework.Commons
{
    /// <summary>
    /// ���������������в���������������б�һ���ǲ����ԣ�һ���Ƕ����Ĳ�����
    /// ��ΪArgsParser��������ͬ���ܵĲ��䡣
    /// </summary>
    public class CommandArgs
    {
        /// <summary>
        /// ���ز���/����ֵ�ļ�ֵ�ֵ�
        /// </summary>
        public Dictionary<string, string> ArgPairs
        {
            get { return mArgPairs; }
        }
    
        /// <summary>
        /// ���ض����Ĳ����б�
        /// </summary>
        public List<string> Params
        {
            get { return mParams; }
        }

        Dictionary<string, string> mArgPairs = new Dictionary<string,string>();
        List<string> mParams = new List<string>();
    }

    /// <summary>
    /// ʵ�������н����ĸ����ࡣ
    /// �����ϣ������Ĳ����������������ϵ��κεط����֡�
    /// �����Ƕ���Ϊ��/ֵ�ԡ�������������'-', '--'����'\'��ʼ���ڲ�����ֵ֮�������
    /// һ���ո�����ַ�'='������Ŀո񽫱����ԡ�
    /// ��������������һ��ֵ�����û��ָ��ֵ����ô�ַ���'true'����ָ����
    /// ���ֵ�пո񣬱���ʹ��˫�����������ַ��������ַ����ܱ���ȷ������  
    /// </summary>
    public class CommandLine
    {
        /// <summary>
        /// �������ݵ������в����������ؽ����һ��CommandArgs����
        /// ���������и�ʽ: CMD [param] [[-|--|\]&lt;arg&gt;[[=]&lt;value&gt;]] [param]
        /// ���磺cmd first -o outfile.txt --compile second \errors=errors.txt third fourth --test = "the value" fifth
        /// </summary>
        /// <param name="args">�����в�������</param>
        /// <returns>����ת����������ж���CommandArgs</returns>
        public static CommandArgs Parse(string[] args)
        {
            char[] kEqual = new char[] { '=' };
            char[] kArgStart = new char[] { '-', '\\' };

            CommandArgs ca = new CommandArgs();
            int ii = -1;
            string token = NextToken( args, ref ii );
            while ( token != null )
            {
                if (IsArg(token))
                {
                    string arg = token.TrimStart(kArgStart).TrimEnd(kEqual);

                    string value = null;

                    if (arg.Contains("="))
                    {
                        // arg was specified with an '=' sign, so we need
                        // to split the string into the arg and value, but only
                        // if there is no space between the '=' and the arg and value.
                        string[] r = arg.Split(kEqual, 2);
                        if ( r.Length == 2 && r[1] != string.Empty)
                        {
                            arg = r[0];
                            value = r[1];
                        }
                    }
                    
                    while ( value == null )
                    {
                        string next = NextToken(args, ref ii);
                        if (next != null)
                        {
                            if (IsArg(next))
                            {
                                // push the token back onto the stack so
                                // it gets picked up on next pass as an Arg
                                ii--;
                                value = "true";
                            }
                            else if (next != "=")
                            {
                                // save the value (trimming any '=' from the start)
                                value = next.TrimStart(kEqual);
                            }
                        }
                    }

                    // save the pair
                    ca.ArgPairs.Add(arg, value);
                }
                else if (token != string.Empty)
                {
                    // this is a stand-alone parameter. 
                    ca.Params.Add(token);
                }

                token = NextToken(args, ref ii);
            }

            return ca;
        }

        /// <summary>
        /// ����true������ݵ��ַ�����һ����������'-'��'--',��'\'��ʼ��
        /// </summary>
        /// <param name="arg">���Ե��ַ������</param>
        /// <returns>������ݵ��ַ�����һ����������true������false</returns>
        static bool IsArg(string arg)
        {
            return (arg.StartsWith("-") || arg.StartsWith("\\"));
        }

        /// <summary>
        /// ���ز����б��е���һ���ַ������
        /// </summary>
        /// <param name="args">�ַ�������б�</param>
        /// <param name="ii">��ǰ�ַ���������б������е�����λ��</param>
        /// <returns>��һ���ַ�����ǣ�����������򷵻�null</returns>
        static string NextToken(string[] args, ref int ii)
        {
            ii++; // move to next token
            while ( ii < args.Length )
            {
                string cur = args[ii].Trim();
                if (cur != string.Empty)
                {
                    // found valid token
                    return cur;
                }
                ii++;
            }

            // failed to get another token
            return null;
        }

    }
}
