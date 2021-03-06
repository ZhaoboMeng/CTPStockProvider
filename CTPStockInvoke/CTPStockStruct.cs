﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace CalmBeltFund.Trading.CTPStock
{
  /// <summary>
  /// 信息分发
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcDisseminationField
  {
    /// <summary>
    /// 序列系列号
    /// </summary>
    [Description("序列系列号")]
    public short SequenceSeries;
    /// <summary>
    /// 序列号
    /// </summary>
    [Description("序列号")]
    public int SequenceNo;

  };

  /// <summary>
  /// 用户登录请求
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcReqUserLoginField
  {
    /// <summary>
    /// 交易日
    /// </summary>
    [Description("交易日")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradingDay;
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 用户代码
    /// </summary>
    [Description("用户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;
    /// <summary>
    /// 密码
    /// </summary>
    [Description("密码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String Password;
    /// <summary>
    /// 用户端产品信息
    /// </summary>
    [Description("用户端产品信息")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String UserProductInfo;
    /// <summary>
    /// 接口端产品信息
    /// </summary>
    [Description("接口端产品信息")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String InterfaceProductInfo;
    /// <summary>
    /// 协议信息
    /// </summary>
    [Description("协议信息")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String ProtocolInfo;
    /// <summary>
    /// Mac地址
    /// </summary>
    [Description("Mac地址")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String MacAddress;
    /// <summary>
    /// 动态密码
    /// </summary>
    [Description("动态密码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String OneTimePassword;
    /// <summary>
    /// 终端IP地址
    /// </summary>
    [Description("终端IP地址")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String ClientIPAddress;

  };

  /// <summary>
  /// 用户登录应答
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcRspUserLoginField
  {
    /// <summary>
    /// 交易日
    /// </summary>
    [Description("交易日")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradingDay;
    /// <summary>
    /// 登录成功时间
    /// </summary>
    [Description("登录成功时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String LoginTime;
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 用户代码
    /// </summary>
    [Description("用户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;
    /// <summary>
    /// 交易系统名称
    /// </summary>
    [Description("交易系统名称")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String SystemName;
    /// <summary>
    /// 前置编号
    /// </summary>
    [Description("前置编号")]
    public int FrontID;
    /// <summary>
    /// 会话编号
    /// </summary>
    [Description("会话编号")]
    public int SessionID;
    /// <summary>
    /// 最大报单引用
    /// </summary>
    [Description("最大报单引用")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String MaxOrderRef;
    /// <summary>
    /// 上期所时间
    /// </summary>
    [Description("上期所时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String SHFETime;
    /// <summary>
    /// 大商所时间
    /// </summary>
    [Description("大商所时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String DCETime;
    /// <summary>
    /// 郑商所时间
    /// </summary>
    [Description("郑商所时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String CZCETime;
    /// <summary>
    /// 中金所时间
    /// </summary>
    [Description("中金所时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String FFEXTime;

  };

  /// <summary>
  /// 用户登出请求
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcUserLogoutField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 用户代码
    /// </summary>
    [Description("用户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;

  };

  /// <summary>
  /// 强制交易员退出
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcForceUserLogoutField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 用户代码
    /// </summary>
    [Description("用户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;

  };

  /// <summary>
  /// 客户端认证请求
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcReqAuthenticateField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 用户代码
    /// </summary>
    [Description("用户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;
    /// <summary>
    /// 用户端产品信息
    /// </summary>
    [Description("用户端产品信息")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String UserProductInfo;
    /// <summary>
    /// 认证码
    /// </summary>
    [Description("认证码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
    public String AuthCode;

  };

  /// <summary>
  /// 客户端认证响应
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcRspAuthenticateField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 用户代码
    /// </summary>
    [Description("用户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;
    /// <summary>
    /// 用户端产品信息
    /// </summary>
    [Description("用户端产品信息")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String UserProductInfo;

  };

  /// <summary>
  /// 客户端认证信息
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcAuthenticationInfoField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 用户代码
    /// </summary>
    [Description("用户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;
    /// <summary>
    /// 用户端产品信息
    /// </summary>
    [Description("用户端产品信息")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String UserProductInfo;
    /// <summary>
    /// 认证信息
    /// </summary>
    [Description("认证信息")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
    public String AuthInfo;
    /// <summary>
    /// 是否为认证结果
    /// </summary>
    [Description("是否为认证结果")]
    public bool IsResult;

  };

  /// <summary>
  /// 银期转帐报文头
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcTransferHeaderField
  {
    /// <summary>
    /// 版本号，常量，1.0
    /// </summary>
    [Description("版本号，常量，1.0")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String Version;
    /// <summary>
    /// 交易代码，必填
    /// </summary>
    [Description("交易代码，必填")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public String TradeCode;
    /// <summary>
    /// 交易日期，必填，格式：yyyymmdd
    /// </summary>
    [Description("交易日期，必填，格式：yyyymmdd")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeDate;
    /// <summary>
    /// 交易时间，必填，格式：hhmmss
    /// </summary>
    [Description("交易时间，必填，格式：hhmmss")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeTime;
    /// <summary>
    /// 发起方流水号，N/A
    /// </summary>
    [Description("发起方流水号，N/A")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeSerial;
    /// <summary>
    /// 期货公司代码，必填
    /// </summary>
    [Description("期货公司代码，必填")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String FutureID;
    /// <summary>
    /// 银行代码，根据查询银行得到，必填
    /// </summary>
    [Description("银行代码，根据查询银行得到，必填")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String BankID;
    /// <summary>
    /// 银行分中心代码，根据查询银行得到，必填
    /// </summary>
    [Description("银行分中心代码，根据查询银行得到，必填")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public String BankBrchID;
    /// <summary>
    /// 操作员，N/A
    /// </summary>
    [Description("操作员，N/A")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
    public String OperNo;
    /// <summary>
    /// 交易设备类型，N/A
    /// </summary>
    [Description("交易设备类型，N/A")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public String DeviceID;
    /// <summary>
    /// 记录数，N/A
    /// </summary>
    [Description("记录数，N/A")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public String RecordNum;
    /// <summary>
    /// 会话编号，N/A
    /// </summary>
    [Description("会话编号，N/A")]
    public int SessionID;
    /// <summary>
    /// 请求编号，N/A
    /// </summary>
    [Description("请求编号，N/A")]
    public int RequestID;

  };

  /// <summary>
  /// 银行资金转期货请求，TradeCode=202001
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcTransferBankToFutureReqField
  {
    /// <summary>
    /// 期货资金账户
    /// </summary>
    [Description("期货资金账户")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String FutureAccount;
    /// <summary>
    /// 密码标志
    /// </summary>
    [Description("密码标志")]
    public CTPStockFuturePwdFlagType FuturePwdFlag;
    /// <summary>
    /// 密码
    /// </summary>
    [Description("密码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
    public String FutureAccPwd;
    /// <summary>
    /// 转账金额
    /// </summary>
    [Description("转账金额")]
    public double TradeAmt;
    /// <summary>
    /// 客户手续费
    /// </summary>
    [Description("客户手续费")]
    public double CustFee;
    /// <summary>
    /// 币种：RMB-人民币 USD-美圆 HKD-港元
    /// </summary>
    [Description("币种：RMB-人民币 USD-美圆 HKD-港元")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String CurrencyCode;

  };

  /// <summary>
  /// 银行资金转期货请求响应
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcTransferBankToFutureRspField
  {
    /// <summary>
    /// 响应代码
    /// </summary>
    [Description("响应代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public String RetCode;
    /// <summary>
    /// 响应信息
    /// </summary>
    [Description("响应信息")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
    public String RetInfo;
    /// <summary>
    /// 资金账户
    /// </summary>
    [Description("资金账户")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String FutureAccount;
    /// <summary>
    /// 转帐金额
    /// </summary>
    [Description("转帐金额")]
    public double TradeAmt;
    /// <summary>
    /// 应收客户手续费
    /// </summary>
    [Description("应收客户手续费")]
    public double CustFee;
    /// <summary>
    /// 币种
    /// </summary>
    [Description("币种")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String CurrencyCode;

  };

  /// <summary>
  /// 期货资金转银行请求，TradeCode=202002
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcTransferFutureToBankReqField
  {
    /// <summary>
    /// 期货资金账户
    /// </summary>
    [Description("期货资金账户")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String FutureAccount;
    /// <summary>
    /// 密码标志
    /// </summary>
    [Description("密码标志")]
    public CTPStockFuturePwdFlagType FuturePwdFlag;
    /// <summary>
    /// 密码
    /// </summary>
    [Description("密码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
    public String FutureAccPwd;
    /// <summary>
    /// 转账金额
    /// </summary>
    [Description("转账金额")]
    public double TradeAmt;
    /// <summary>
    /// 客户手续费
    /// </summary>
    [Description("客户手续费")]
    public double CustFee;
    /// <summary>
    /// 币种：RMB-人民币 USD-美圆 HKD-港元
    /// </summary>
    [Description("币种：RMB-人民币 USD-美圆 HKD-港元")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String CurrencyCode;

  };

  /// <summary>
  /// 期货资金转银行请求响应
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcTransferFutureToBankRspField
  {
    /// <summary>
    /// 响应代码
    /// </summary>
    [Description("响应代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public String RetCode;
    /// <summary>
    /// 响应信息
    /// </summary>
    [Description("响应信息")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
    public String RetInfo;
    /// <summary>
    /// 资金账户
    /// </summary>
    [Description("资金账户")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String FutureAccount;
    /// <summary>
    /// 转帐金额
    /// </summary>
    [Description("转帐金额")]
    public double TradeAmt;
    /// <summary>
    /// 应收客户手续费
    /// </summary>
    [Description("应收客户手续费")]
    public double CustFee;
    /// <summary>
    /// 币种
    /// </summary>
    [Description("币种")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String CurrencyCode;

  };

  /// <summary>
  /// 查询银行资金请求，TradeCode=204002
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcTransferQryBankReqField
  {
    /// <summary>
    /// 期货资金账户
    /// </summary>
    [Description("期货资金账户")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String FutureAccount;
    /// <summary>
    /// 密码标志
    /// </summary>
    [Description("密码标志")]
    public CTPStockFuturePwdFlagType FuturePwdFlag;
    /// <summary>
    /// 密码
    /// </summary>
    [Description("密码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
    public String FutureAccPwd;
    /// <summary>
    /// 币种：RMB-人民币 USD-美圆 HKD-港元
    /// </summary>
    [Description("币种：RMB-人民币 USD-美圆 HKD-港元")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String CurrencyCode;

  };

  /// <summary>
  /// 查询银行资金请求响应
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcTransferQryBankRspField
  {
    /// <summary>
    /// 响应代码
    /// </summary>
    [Description("响应代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public String RetCode;
    /// <summary>
    /// 响应信息
    /// </summary>
    [Description("响应信息")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
    public String RetInfo;
    /// <summary>
    /// 资金账户
    /// </summary>
    [Description("资金账户")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String FutureAccount;
    /// <summary>
    /// 银行余额
    /// </summary>
    [Description("银行余额")]
    public double TradeAmt;
    /// <summary>
    /// 银行可用余额
    /// </summary>
    [Description("银行可用余额")]
    public double UseAmt;
    /// <summary>
    /// 银行可取余额
    /// </summary>
    [Description("银行可取余额")]
    public double FetchAmt;
    /// <summary>
    /// 币种
    /// </summary>
    [Description("币种")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String CurrencyCode;

  };

  /// <summary>
  /// 查询银行交易明细请求，TradeCode=204999
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcTransferQryDetailReqField
  {
    /// <summary>
    /// 期货资金账户
    /// </summary>
    [Description("期货资金账户")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String FutureAccount;

  };

  /// <summary>
  /// 查询银行交易明细请求响应
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcTransferQryDetailRspField
  {
    /// <summary>
    /// 交易日期
    /// </summary>
    [Description("交易日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeDate;
    /// <summary>
    /// 交易时间
    /// </summary>
    [Description("交易时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeTime;
    /// <summary>
    /// 交易代码
    /// </summary>
    [Description("交易代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public String TradeCode;
    /// <summary>
    /// 期货流水号
    /// </summary>
    [Description("期货流水号")]
    public int FutureSerial;
    /// <summary>
    /// 期货公司代码
    /// </summary>
    [Description("期货公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String FutureID;
    /// <summary>
    /// 资金帐号
    /// </summary>
    [Description("资金帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 22)]
    public String FutureAccount;
    /// <summary>
    /// 银行流水号
    /// </summary>
    [Description("银行流水号")]
    public int BankSerial;
    /// <summary>
    /// 银行代码
    /// </summary>
    [Description("银行代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String BankID;
    /// <summary>
    /// 银行分中心代码
    /// </summary>
    [Description("银行分中心代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public String BankBrchID;
    /// <summary>
    /// 银行账号
    /// </summary>
    [Description("银行账号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String BankAccount;
    /// <summary>
    /// 证件号码
    /// </summary>
    [Description("证件号码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String CertCode;
    /// <summary>
    /// 货币代码
    /// </summary>
    [Description("货币代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String CurrencyCode;
    /// <summary>
    /// 发生金额
    /// </summary>
    [Description("发生金额")]
    public double TxAmount;
    /// <summary>
    /// 有效标志
    /// </summary>
    [Description("有效标志")]
    public CTPStockTransferValidFlagType Flag;

  };

  /// <summary>
  /// 响应信息
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcRspInfoField
  {
    /// <summary>
    /// 错误代码
    /// </summary>
    [Description("错误代码")]
    public int ErrorID;
    /// <summary>
    /// 错误信息
    /// </summary>
    [Description("错误信息")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
    public String ErrorMsg;

  };

  /// <summary>
  /// 交易所
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcExchangeField
  {
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;
    /// <summary>
    /// 交易所名称
    /// </summary>
    [Description("交易所名称")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String ExchangeName;
    /// <summary>
    /// 交易所属性
    /// </summary>
    [Description("交易所属性")]
    public CTPStockExchangePropertyType ExchangeProperty;

  };

  /// <summary>
  /// 产品
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcProductField
  {
    /// <summary>
    /// 产品代码
    /// </summary>
    [Description("产品代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String ProductID;
    /// <summary>
    /// 产品名称
    /// </summary>
    [Description("产品名称")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String ProductName;
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;
    /// <summary>
    /// 产品类型
    /// </summary>
    [Description("产品类型")]
    public CTPStockProductClassType ProductClass;
    /// <summary>
    /// 合约数量乘数
    /// </summary>
    [Description("合约数量乘数")]
    public int VolumeMultiple;
    /// <summary>
    /// 最小变动价位
    /// </summary>
    [Description("最小变动价位")]
    public double PriceTick;
    /// <summary>
    /// 市价单最大下单量
    /// </summary>
    [Description("市价单最大下单量")]
    public int MaxMarketOrderVolume;
    /// <summary>
    /// 市价单最小下单量
    /// </summary>
    [Description("市价单最小下单量")]
    public int MinMarketOrderVolume;
    /// <summary>
    /// 限价单最大下单量
    /// </summary>
    [Description("限价单最大下单量")]
    public int MaxLimitOrderVolume;
    /// <summary>
    /// 限价单最小下单量
    /// </summary>
    [Description("限价单最小下单量")]
    public int MinLimitOrderVolume;
    /// <summary>
    /// 持仓类型
    /// </summary>
    [Description("持仓类型")]
    public CTPStockPositionType PositionType;
    /// <summary>
    /// 持仓日期类型
    /// </summary>
    [Description("持仓日期类型")]
    public CTPStockPositionDateType PositionDateType;
    /// <summary>
    /// ETF最小交易单位
    /// </summary>
    [Description("ETF最小交易单位")]
    public int EFTMinTradeVolume;

  };

  /// <summary>
  /// 合约
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcInstrumentField
  {
    /// <summary>
    /// 合约代码
    /// </summary>
    [Description("合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String InstrumentID;
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;
    /// <summary>
    /// 合约名称
    /// </summary>
    [Description("合约名称")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String InstrumentName;
    /// <summary>
    /// 合约在交易所的代码
    /// </summary>
    [Description("合约在交易所的代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String ExchangeInstID;
    /// <summary>
    /// 产品代码
    /// </summary>
    [Description("产品代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String ProductID;
    /// <summary>
    /// 产品类型
    /// </summary>
    [Description("产品类型")]
    public CTPStockProductClassType ProductClass;
    /// <summary>
    /// 交割年份
    /// </summary>
    [Description("交割年份")]
    public int DeliveryYear;
    /// <summary>
    /// 交割月
    /// </summary>
    [Description("交割月")]
    public int DeliveryMonth;
    /// <summary>
    /// 市价单最大下单量
    /// </summary>
    [Description("市价单最大下单量")]
    public int MaxMarketOrderVolume;
    /// <summary>
    /// 市价单最小下单量
    /// </summary>
    [Description("市价单最小下单量")]
    public int MinMarketOrderVolume;
    /// <summary>
    /// 限价单最大下单量
    /// </summary>
    [Description("限价单最大下单量")]
    public int MaxLimitOrderVolume;
    /// <summary>
    /// 限价单最小下单量
    /// </summary>
    [Description("限价单最小下单量")]
    public int MinLimitOrderVolume;
    /// <summary>
    /// 合约数量乘数
    /// </summary>
    [Description("合约数量乘数")]
    public int VolumeMultiple;
    /// <summary>
    /// 最小变动价位
    /// </summary>
    [Description("最小变动价位")]
    public double PriceTick;
    /// <summary>
    /// 创建日
    /// </summary>
    [Description("创建日")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String CreateDate;
    /// <summary>
    /// 上市日
    /// </summary>
    [Description("上市日")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String OpenDate;
    /// <summary>
    /// 到期日
    /// </summary>
    [Description("到期日")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExpireDate;
    /// <summary>
    /// 开始交割日
    /// </summary>
    [Description("开始交割日")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String StartDelivDate;
    /// <summary>
    /// 结束交割日
    /// </summary>
    [Description("结束交割日")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String EndDelivDate;
    /// <summary>
    /// 合约生命周期状态
    /// </summary>
    [Description("合约生命周期状态")]
    public CTPStockInstLifePhaseType InstLifePhase;
    /// <summary>
    /// 当前是否交易
    /// </summary>
    [Description("当前是否交易")]
    public bool IsTrading;
    /// <summary>
    /// 持仓类型
    /// </summary>
    [Description("持仓类型")]
    public CTPStockPositionType PositionType;
    /// <summary>
    /// 持仓日期类型
    /// </summary>
    [Description("持仓日期类型")]
    public CTPStockPositionDateType PositionDateType;
    /// <summary>
    /// 多头保证金率
    /// </summary>
    [Description("多头保证金率")]
    public double LongMarginRatio;
    /// <summary>
    /// 空头保证金率
    /// </summary>
    [Description("空头保证金率")]
    public double ShortMarginRatio;
    /// <summary>
    /// 报单能否撤单
    /// </summary>
    [Description("报单能否撤单")]
    public bool OrderCanBeWithdraw;
    /// <summary>
    /// 最小买下单单位
    /// </summary>
    [Description("最小买下单单位")]
    public int MinBuyVolume;
    /// <summary>
    /// 最小卖下单单位
    /// </summary>
    [Description("最小卖下单单位")]
    public int MinSellVolume;

  };

  /// <summary>
  /// 经纪公司
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcBrokerField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 经纪公司简称
    /// </summary>
    [Description("经纪公司简称")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String BrokerAbbr;
    /// <summary>
    /// 经纪公司名称
    /// </summary>
    [Description("经纪公司名称")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
    public String BrokerName;
    /// <summary>
    /// 是否活跃
    /// </summary>
    [Description("是否活跃")]
    public bool IsActive;

  };

  /// <summary>
  /// 交易所交易员
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcTraderField
  {
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;
    /// <summary>
    /// 交易所交易员代码
    /// </summary>
    [Description("交易所交易员代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String TraderID;
    /// <summary>
    /// 会员代码
    /// </summary>
    [Description("会员代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String ParticipantID;
    /// <summary>
    /// 密码
    /// </summary>
    [Description("密码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String Password;
    /// <summary>
    /// 安装数量
    /// </summary>
    [Description("安装数量")]
    public int InstallCount;
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 营业部编号
    /// </summary>
    [Description("营业部编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String BranchID;

  };

  /// <summary>
  /// 投资者
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcInvestorField
  {
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者分组代码
    /// </summary>
    [Description("投资者分组代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorGroupID;
    /// <summary>
    /// 投资者名称
    /// </summary>
    [Description("投资者名称")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
    public String InvestorName;
    /// <summary>
    /// 证件类型
    /// </summary>
    [Description("证件类型")]
    public CTPStockIdCardType IdentifiedCardType;
    /// <summary>
    /// 证件号码
    /// </summary>
    [Description("证件号码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
    public String IdentifiedCardNo;
    /// <summary>
    /// 是否活跃
    /// </summary>
    [Description("是否活跃")]
    public bool IsActive;
    /// <summary>
    /// 联系电话
    /// </summary>
    [Description("联系电话")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String Telephone;
    /// <summary>
    /// 通讯地址
    /// </summary>
    [Description("通讯地址")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
    public String Address;
    /// <summary>
    /// 开户日期
    /// </summary>
    [Description("开户日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String OpenDate;
    /// <summary>
    /// 手机
    /// </summary>
    [Description("手机")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String Mobile;
    /// <summary>
    /// 上海营业部编号
    /// </summary>
    [Description("上海营业部编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String SHBranchID;
    /// <summary>
    /// 深圳营业部编号
    /// </summary>
    [Description("深圳营业部编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String SZBranchID;
    /// <summary>
    /// 是否信用账户
    /// </summary>
    [Description("是否信用账户")]
    public bool IsCreditAccount;

  };

  /// <summary>
  /// 交易编码
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcTradingCodeField
  {
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;
    /// <summary>
    /// 客户代码
    /// </summary>
    [Description("客户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String ClientID;
    /// <summary>
    /// 是否活跃
    /// </summary>
    [Description("是否活跃")]
    public bool IsActive;

  };

  /// <summary>
  /// 会员编码和经纪公司编码对照表
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcPartBrokerField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;
    /// <summary>
    /// 会员代码
    /// </summary>
    [Description("会员代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String ParticipantID;
    /// <summary>
    /// 是否活跃
    /// </summary>
    [Description("是否活跃")]
    public bool IsActive;

  };

  /// <summary>
  /// 管理用户
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcSuperUserField
  {
    /// <summary>
    /// 用户代码
    /// </summary>
    [Description("用户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;
    /// <summary>
    /// 用户名称
    /// </summary>
    [Description("用户名称")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
    public String UserName;
    /// <summary>
    /// 密码
    /// </summary>
    [Description("密码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String Password;
    /// <summary>
    /// 是否活跃
    /// </summary>
    [Description("是否活跃")]
    public bool IsActive;

  };

  /// <summary>
  /// 管理用户功能权限
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcSuperUserFunctionField
  {
    /// <summary>
    /// 用户代码
    /// </summary>
    [Description("用户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;
    /// <summary>
    /// 功能代码
    /// </summary>
    [Description("功能代码")]
    public CTPStockFunctionCodeType FunctionCode;

  };

  /// <summary>
  /// 投资者组
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcInvestorGroupField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者分组代码
    /// </summary>
    [Description("投资者分组代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorGroupID;
    /// <summary>
    /// 投资者分组名称
    /// </summary>
    [Description("投资者分组名称")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String InvestorGroupName;

  };

  /// <summary>
  /// 资金账户
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcTradingAccountField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者帐号
    /// </summary>
    [Description("投资者帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String AccountID;
    /// <summary>
    /// 上次质押金额
    /// </summary>
    [Description("上次质押金额")]
    public double PreMortgage;
    /// <summary>
    /// 上次信用额度
    /// </summary>
    [Description("上次信用额度")]
    public double PreCredit;
    /// <summary>
    /// 上次存款额
    /// </summary>
    [Description("上次存款额")]
    public double PreDeposit;
    /// <summary>
    /// 上次结算准备金
    /// </summary>
    [Description("上次结算准备金")]
    public double PreBalance;
    /// <summary>
    /// 上次占用的保证金
    /// </summary>
    [Description("上次占用的保证金")]
    public double PreMargin;
    /// <summary>
    /// 利息基数
    /// </summary>
    [Description("利息基数")]
    public double InterestBase;
    /// <summary>
    /// 利息收入
    /// </summary>
    [Description("利息收入")]
    public double Interest;
    /// <summary>
    /// 入金金额
    /// </summary>
    [Description("入金金额")]
    public double Deposit;
    /// <summary>
    /// 出金金额
    /// </summary>
    [Description("出金金额")]
    public double Withdraw;
    /// <summary>
    /// 冻结的保证金
    /// </summary>
    [Description("冻结的保证金")]
    public double FrozenMargin;
    /// <summary>
    /// 冻结的资金
    /// </summary>
    [Description("冻结的资金")]
    public double FrozenCash;
    /// <summary>
    /// 冻结的手续费
    /// </summary>
    [Description("冻结的手续费")]
    public double FrozenCommission;
    /// <summary>
    /// 当前保证金总额
    /// </summary>
    [Description("当前保证金总额")]
    public double CurrMargin;
    /// <summary>
    /// 资金差额
    /// </summary>
    [Description("资金差额")]
    public double CashIn;
    /// <summary>
    /// 手续费
    /// </summary>
    [Description("手续费")]
    public double Commission;
    /// <summary>
    /// 平仓盈亏
    /// </summary>
    [Description("平仓盈亏")]
    public double CloseProfit;
    /// <summary>
    /// 持仓盈亏
    /// </summary>
    [Description("持仓盈亏")]
    public double PositionProfit;
    /// <summary>
    /// 期货结算准备金
    /// </summary>
    [Description("期货结算准备金")]
    public double Balance;
    /// <summary>
    /// 可用资金
    /// </summary>
    [Description("可用资金")]
    public double Available;
    /// <summary>
    /// 可取资金
    /// </summary>
    [Description("可取资金")]
    public double WithdrawQuota;
    /// <summary>
    /// 基本准备金
    /// </summary>
    [Description("基本准备金")]
    public double Reserve;
    /// <summary>
    /// 交易日
    /// </summary>
    [Description("交易日")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradingDay;
    /// <summary>
    /// 结算编号
    /// </summary>
    [Description("结算编号")]
    public int SettlementID;
    /// <summary>
    /// 信用额度
    /// </summary>
    [Description("信用额度")]
    public double Credit;
    /// <summary>
    /// 质押金额
    /// </summary>
    [Description("质押金额")]
    public double Mortgage;
    /// <summary>
    /// 交易所保证金
    /// </summary>
    [Description("交易所保证金")]
    public double ExchangeMargin;
    /// <summary>
    /// 投资者交割保证金
    /// </summary>
    [Description("投资者交割保证金")]
    public double DeliveryMargin;
    /// <summary>
    /// 交易所交割保证金
    /// </summary>
    [Description("交易所交割保证金")]
    public double ExchangeDeliveryMargin;
    /// <summary>
    /// 冻结的过户费
    /// </summary>
    [Description("冻结的过户费")]
    public double FrozenTransferFee;
    /// <summary>
    /// 冻结的印花税
    /// </summary>
    [Description("冻结的印花税")]
    public double FrozenStampTax;
    /// <summary>
    /// 过户费
    /// </summary>
    [Description("过户费")]
    public double TransferFee;
    /// <summary>
    /// 印花税
    /// </summary>
    [Description("印花税")]
    public double StampTax;
    /// <summary>
    /// 折算金额
    /// </summary>
    [Description("折算金额")]
    public double ConversionAmount;
    /// <summary>
    /// 授信额度
    /// </summary>
    [Description("授信额度")]
    public double CreditAmount;
    /// <summary>
    /// 最低维持担保比例
    /// </summary>
    [Description("最低维持担保比例")]
    public double LowLimitRatio;
    /// <summary>
    /// 融资买入金额
    /// </summary>
    [Description("融资买入金额")]
    public double MarginTradingAmount;
    /// <summary>
    /// 融券卖出金额
    /// </summary>
    [Description("融券卖出金额")]
    public double ShortSellingAmount;
    /// <summary>
    /// 融资买入可用金额
    /// </summary>
    [Description("融资买入可用金额")]
    public double MarginTradingAvail;
    /// <summary>
    /// 融券卖出可用金额
    /// </summary>
    [Description("融券卖出可用金额")]
    public double ShortSellingAvail;
    /// <summary>
    /// 维持担保比例
    /// </summary>
    [Description("维持担保比例")]
    public double CreditRatio;
    /// <summary>
    /// 证券总价值
    /// </summary>
    [Description("证券总价值")]
    public double StockValue;

  };

  /// <summary>
  /// 投资者持仓
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcInvestorPositionField
  {
    /// <summary>
    /// 合约代码
    /// </summary>
    [Description("合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String InstrumentID;
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 持仓多空方向
    /// </summary>
    [Description("持仓多空方向")]
    public CTPStockPosiDirectionType PosiDirection;
    /// <summary>
    /// 投机套保标志
    /// </summary>
    [Description("投机套保标志")]
    public CTPStockHedgeFlagType HedgeFlag;
    /// <summary>
    /// 持仓日期
    /// </summary>
    [Description("持仓日期")]
    public CTPStockPositionDateType PositionDate;
    /// <summary>
    /// 上日持仓
    /// </summary>
    [Description("上日持仓")]
    public int YdPosition;
    /// <summary>
    /// 今日持仓
    /// </summary>
    [Description("今日持仓")]
    public int Position;
    /// <summary>
    /// 多头冻结
    /// </summary>
    [Description("多头冻结")]
    public int LongFrozen;
    /// <summary>
    /// 空头冻结
    /// </summary>
    [Description("空头冻结")]
    public int ShortFrozen;
    /// <summary>
    /// 开仓冻结金额
    /// </summary>
    [Description("开仓冻结金额")]
    public double LongFrozenAmount;
    /// <summary>
    /// 开仓冻结金额
    /// </summary>
    [Description("开仓冻结金额")]
    public double ShortFrozenAmount;
    /// <summary>
    /// 开仓量
    /// </summary>
    [Description("开仓量")]
    public int OpenVolume;
    /// <summary>
    /// 平仓量
    /// </summary>
    [Description("平仓量")]
    public int CloseVolume;
    /// <summary>
    /// 开仓金额
    /// </summary>
    [Description("开仓金额")]
    public double OpenAmount;
    /// <summary>
    /// 平仓金额
    /// </summary>
    [Description("平仓金额")]
    public double CloseAmount;
    /// <summary>
    /// 持仓成本
    /// </summary>
    [Description("持仓成本")]
    public double PositionCost;
    /// <summary>
    /// 冻结的资金
    /// </summary>
    [Description("冻结的资金")]
    public double FrozenCash;
    /// <summary>
    /// 资金差额
    /// </summary>
    [Description("资金差额")]
    public double CashIn;
    /// <summary>
    /// 手续费
    /// </summary>
    [Description("手续费")]
    public double Commission;
    /// <summary>
    /// 平仓盈亏
    /// </summary>
    [Description("平仓盈亏")]
    public double CloseProfit;
    /// <summary>
    /// 持仓盈亏
    /// </summary>
    [Description("持仓盈亏")]
    public double PositionProfit;
    /// <summary>
    /// 上次结算价
    /// </summary>
    [Description("上次结算价")]
    public double PreSettlementPrice;
    /// <summary>
    /// 本次结算价
    /// </summary>
    [Description("本次结算价")]
    public double SettlementPrice;
    /// <summary>
    /// 交易日
    /// </summary>
    [Description("交易日")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradingDay;
    /// <summary>
    /// 结算编号
    /// </summary>
    [Description("结算编号")]
    public int SettlementID;
    /// <summary>
    /// 开仓成本
    /// </summary>
    [Description("开仓成本")]
    public double OpenCost;
    /// <summary>
    /// 交易所保证金
    /// </summary>
    [Description("交易所保证金")]
    public double ExchangeMargin;
    /// <summary>
    /// 今日持仓
    /// </summary>
    [Description("今日持仓")]
    public int TodayPosition;
    /// <summary>
    /// 过户费
    /// </summary>
    [Description("过户费")]
    public double TransferFee;
    /// <summary>
    /// 印花税
    /// </summary>
    [Description("印花税")]
    public double StampTax;
    /// <summary>
    /// 今日申购赎回数量
    /// </summary>
    [Description("今日申购赎回数量")]
    public int TodayPurRedVolume;
    /// <summary>
    /// 折算率
    /// </summary>
    [Description("折算率")]
    public double ConversionRate;
    /// <summary>
    /// 折算金额
    /// </summary>
    [Description("折算金额")]
    public double ConversionAmount;
    /// <summary>
    /// 融资买入出数量
    /// </summary>
    [Description("融资买入出数量")]
    public int MarginTradeVolume;
    /// <summary>
    /// 融资买入金额
    /// </summary>
    [Description("融资买入金额")]
    public double MarginTradeAmount;
    /// <summary>
    /// 融资买入冻结数量
    /// </summary>
    [Description("融资买入冻结数量")]
    public int MarginTradeFrozenVolume;
    /// <summary>
    /// 融资买入冻结金额
    /// </summary>
    [Description("融资买入冻结金额")]
    public double MarginTradeFrozenAmount;
    /// <summary>
    /// 融资买入折算金额
    /// </summary>
    [Description("融资买入折算金额")]
    public double MarginTradeConversionAmount;
    /// <summary>
    /// 融券卖出数量
    /// </summary>
    [Description("融券卖出数量")]
    public int ShortSellVolume;
    /// <summary>
    /// 融券卖出金额
    /// </summary>
    [Description("融券卖出金额")]
    public double ShortSellAmount;
    /// <summary>
    /// 融券卖出折算金额
    /// </summary>
    [Description("融券卖出折算金额")]
    public double ShortSellConversionAmount;
    /// <summary>
    /// 融券卖出冻结数量
    /// </summary>
    [Description("融券卖出冻结数量")]
    public int ShortSellFrozenVolume;
    /// <summary>
    /// 融券卖出冻结金额
    /// </summary>
    [Description("融券卖出冻结金额")]
    public double ShortSellFrozenAmount;
    /// <summary>
    /// 证券价值
    /// </summary>
    [Description("证券价值")]
    public double StockValue;
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;

  };

  /// <summary>
  /// 合约保证金率
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcInstrumentMarginRateField
  {
    /// <summary>
    /// 合约代码
    /// </summary>
    [Description("合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String InstrumentID;
    /// <summary>
    /// 投资者范围
    /// </summary>
    [Description("投资者范围")]
    public CTPStockInvestorRangeType InvestorRange;
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 投机套保标志
    /// </summary>
    [Description("投机套保标志")]
    public CTPStockHedgeFlagType HedgeFlag;
    /// <summary>
    /// 多头保证金率
    /// </summary>
    [Description("多头保证金率")]
    public double LongMarginRatioByMoney;
    /// <summary>
    /// 多头保证金费
    /// </summary>
    [Description("多头保证金费")]
    public double LongMarginRatioByVolume;
    /// <summary>
    /// 空头保证金率
    /// </summary>
    [Description("空头保证金率")]
    public double ShortMarginRatioByMoney;
    /// <summary>
    /// 空头保证金费
    /// </summary>
    [Description("空头保证金费")]
    public double ShortMarginRatioByVolume;
    /// <summary>
    /// 是否相对交易所收取
    /// </summary>
    [Description("是否相对交易所收取")]
    public bool IsRelative;

  };

  /// <summary>
  /// 合约手续费率
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcInstrumentCommissionRateField
  {
    /// <summary>
    /// 合约代码
    /// </summary>
    [Description("合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String InstrumentID;
    /// <summary>
    /// 投资者范围
    /// </summary>
    [Description("投资者范围")]
    public CTPStockInvestorRangeType InvestorRange;
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 买印花税率
    /// </summary>
    [Description("买印花税率")]
    public double BuyStampTaxRateByMoney;
    /// <summary>
    /// 买印花税率(按手数)
    /// </summary>
    [Description("买印花税率(按手数)")]
    public double BuyStampTaxRateByVolume;
    /// <summary>
    /// 卖印花税率
    /// </summary>
    [Description("卖印花税率")]
    public double SellStampTaxRateByMoney;
    /// <summary>
    /// 卖印花税率(按手数)
    /// </summary>
    [Description("卖印花税率(按手数)")]
    public double SellStampTaxRateByVolume;
    /// <summary>
    /// 买过户费率
    /// </summary>
    [Description("买过户费率")]
    public double BuyTransferFeeRateByMoney;
    /// <summary>
    /// 买过户费率(按手数)
    /// </summary>
    [Description("买过户费率(按手数)")]
    public double BuyTransferFeeRateByVolume;
    /// <summary>
    /// 卖过户费率
    /// </summary>
    [Description("卖过户费率")]
    public double SellTransferFeeRateByMoney;
    /// <summary>
    /// 卖过户费率(按手数)
    /// </summary>
    [Description("卖过户费率(按手数)")]
    public double SellTransferFeeRateByVolume;
    /// <summary>
    /// 买交易费
    /// </summary>
    [Description("买交易费")]
    public double BuyTradeFeeByMoney;
    /// <summary>
    /// 买交易费(按手数)
    /// </summary>
    [Description("买交易费(按手数)")]
    public double BuyTradeFeeByVolume;
    /// <summary>
    /// 卖交易费率
    /// </summary>
    [Description("卖交易费率")]
    public double SellTradeFeeByMoney;
    /// <summary>
    /// 卖交易费率(按手数)
    /// </summary>
    [Description("卖交易费率(按手数)")]
    public double SellTradeFeeByVolume;
    /// <summary>
    /// 买交易附加费率
    /// </summary>
    [Description("买交易附加费率")]
    public double BuyMarginByMoney;
    /// <summary>
    /// 卖交易附加费率
    /// </summary>
    [Description("卖交易附加费率")]
    public double SellMarginByMoney;
    /// <summary>
    /// 最小过户费
    /// </summary>
    [Description("最小过户费")]
    public double MinTradeFee;

  };

  /// <summary>
  /// 深度行情
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcDepthMarketDataField
  {
    /// <summary>
    /// 交易日
    /// </summary>
    [Description("交易日")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradingDay;
    /// <summary>
    /// 合约代码
    /// </summary>
    [Description("合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String InstrumentID;
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;
    /// <summary>
    /// 合约在交易所的代码
    /// </summary>
    [Description("合约在交易所的代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String ExchangeInstID;
    /// <summary>
    /// 最新价
    /// </summary>
    [Description("最新价")]
    public double LastPrice;
    /// <summary>
    /// 上次结算价
    /// </summary>
    [Description("上次结算价")]
    public double PreSettlementPrice;
    /// <summary>
    /// 昨收盘
    /// </summary>
    [Description("昨收盘")]
    public double PreClosePrice;
    /// <summary>
    /// 昨持仓量
    /// </summary>
    [Description("昨持仓量")]
    public double PreOpenInterest;
    /// <summary>
    /// 今开盘
    /// </summary>
    [Description("今开盘")]
    public double OpenPrice;
    /// <summary>
    /// 最高价
    /// </summary>
    [Description("最高价")]
    public double HighestPrice;
    /// <summary>
    /// 最低价
    /// </summary>
    [Description("最低价")]
    public double LowestPrice;
    /// <summary>
    /// 数量
    /// </summary>
    [Description("数量")]
    public int Volume;
    /// <summary>
    /// 成交金额
    /// </summary>
    [Description("成交金额")]
    public double Turnover;
    /// <summary>
    /// 持仓量
    /// </summary>
    [Description("持仓量")]
    public double OpenInterest;
    /// <summary>
    /// 今收盘
    /// </summary>
    [Description("今收盘")]
    public double ClosePrice;
    /// <summary>
    /// 本次结算价
    /// </summary>
    [Description("本次结算价")]
    public double SettlementPrice;
    /// <summary>
    /// 涨停板价
    /// </summary>
    [Description("涨停板价")]
    public double UpperLimitPrice;
    /// <summary>
    /// 跌停板价
    /// </summary>
    [Description("跌停板价")]
    public double LowerLimitPrice;
    /// <summary>
    /// 昨虚实度
    /// </summary>
    [Description("昨虚实度")]
    public double PreDelta;
    /// <summary>
    /// 今虚实度
    /// </summary>
    [Description("今虚实度")]
    public double CurrDelta;
    /// <summary>
    /// 最后修改时间
    /// </summary>
    [Description("最后修改时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String UpdateTime;
    /// <summary>
    /// 最后修改毫秒
    /// </summary>
    [Description("最后修改毫秒")]
    public int UpdateMillisec;
    /// <summary>
    /// 申买价一
    /// </summary>
    [Description("申买价一")]
    public double BidPrice1;
    /// <summary>
    /// 申买量一
    /// </summary>
    [Description("申买量一")]
    public int BidVolume1;
    /// <summary>
    /// 申卖价一
    /// </summary>
    [Description("申卖价一")]
    public double AskPrice1;
    /// <summary>
    /// 申卖量一
    /// </summary>
    [Description("申卖量一")]
    public int AskVolume1;
    /// <summary>
    /// 申买价二
    /// </summary>
    [Description("申买价二")]
    public double BidPrice2;
    /// <summary>
    /// 申买量二
    /// </summary>
    [Description("申买量二")]
    public int BidVolume2;
    /// <summary>
    /// 申卖价二
    /// </summary>
    [Description("申卖价二")]
    public double AskPrice2;
    /// <summary>
    /// 申卖量二
    /// </summary>
    [Description("申卖量二")]
    public int AskVolume2;
    /// <summary>
    /// 申买价三
    /// </summary>
    [Description("申买价三")]
    public double BidPrice3;
    /// <summary>
    /// 申买量三
    /// </summary>
    [Description("申买量三")]
    public int BidVolume3;
    /// <summary>
    /// 申卖价三
    /// </summary>
    [Description("申卖价三")]
    public double AskPrice3;
    /// <summary>
    /// 申卖量三
    /// </summary>
    [Description("申卖量三")]
    public int AskVolume3;
    /// <summary>
    /// 申买价四
    /// </summary>
    [Description("申买价四")]
    public double BidPrice4;
    /// <summary>
    /// 申买量四
    /// </summary>
    [Description("申买量四")]
    public int BidVolume4;
    /// <summary>
    /// 申卖价四
    /// </summary>
    [Description("申卖价四")]
    public double AskPrice4;
    /// <summary>
    /// 申卖量四
    /// </summary>
    [Description("申卖量四")]
    public int AskVolume4;
    /// <summary>
    /// 申买价五
    /// </summary>
    [Description("申买价五")]
    public double BidPrice5;
    /// <summary>
    /// 申买量五
    /// </summary>
    [Description("申买量五")]
    public int BidVolume5;
    /// <summary>
    /// 申卖价五
    /// </summary>
    [Description("申卖价五")]
    public double AskPrice5;
    /// <summary>
    /// 申卖量五
    /// </summary>
    [Description("申卖量五")]
    public int AskVolume5;
    /// <summary>
    /// 当日均价
    /// </summary>
    [Description("当日均价")]
    public double AveragePrice;

  };

  /// <summary>
  /// 投资者合约交易权限
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcInstrumentTradingRightField
  {
    /// <summary>
    /// 合约代码
    /// </summary>
    [Description("合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String InstrumentID;
    /// <summary>
    /// 投资者范围
    /// </summary>
    [Description("投资者范围")]
    public CTPStockInvestorRangeType InvestorRange;
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 买卖
    /// </summary>
    [Description("买卖")]
    public CTPStockDirectionType Direction;
    /// <summary>
    /// 交易权限
    /// </summary>
    [Description("交易权限")]
    public CTPStockTradingRightType TradingRight;
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;

  };

  /// <summary>
  /// 经纪公司用户
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcBrokerUserField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 用户代码
    /// </summary>
    [Description("用户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;
    /// <summary>
    /// 用户名称
    /// </summary>
    [Description("用户名称")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
    public String UserName;
    /// <summary>
    /// 用户类型
    /// </summary>
    [Description("用户类型")]
    public CTPStockUserType UserType;
    /// <summary>
    /// 是否活跃
    /// </summary>
    [Description("是否活跃")]
    public bool IsActive;
    /// <summary>
    /// 是否使用令牌
    /// </summary>
    [Description("是否使用令牌")]
    public bool IsUsingOTP;

  };

  /// <summary>
  /// 经纪公司用户口令
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcBrokerUserPasswordField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 用户代码
    /// </summary>
    [Description("用户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;
    /// <summary>
    /// 密码
    /// </summary>
    [Description("密码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String Password;

  };

  /// <summary>
  /// 经纪公司用户功能权限
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcBrokerUserFunctionField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 用户代码
    /// </summary>
    [Description("用户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;
    /// <summary>
    /// 经纪公司功能代码
    /// </summary>
    [Description("经纪公司功能代码")]
    public CTPStockBrokerFunctionCodeType BrokerFunctionCode;

  };

  /// <summary>
  /// 交易所交易员报盘机
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcTraderOfferField
  {
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;
    /// <summary>
    /// 交易所交易员代码
    /// </summary>
    [Description("交易所交易员代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String TraderID;
    /// <summary>
    /// 会员代码
    /// </summary>
    [Description("会员代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String ParticipantID;
    /// <summary>
    /// 密码
    /// </summary>
    [Description("密码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String Password;
    /// <summary>
    /// 安装编号
    /// </summary>
    [Description("安装编号")]
    public int InstallID;
    /// <summary>
    /// 本地报单编号
    /// </summary>
    [Description("本地报单编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String OrderLocalID;
    /// <summary>
    /// 交易所交易员连接状态
    /// </summary>
    [Description("交易所交易员连接状态")]
    public CTPStockTraderConnectStatusType TraderConnectStatus;
    /// <summary>
    /// 发出连接请求的日期
    /// </summary>
    [Description("发出连接请求的日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ConnectRequestDate;
    /// <summary>
    /// 发出连接请求的时间
    /// </summary>
    [Description("发出连接请求的时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ConnectRequestTime;
    /// <summary>
    /// 上次报告日期
    /// </summary>
    [Description("上次报告日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String LastReportDate;
    /// <summary>
    /// 上次报告时间
    /// </summary>
    [Description("上次报告时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String LastReportTime;
    /// <summary>
    /// 完成连接日期
    /// </summary>
    [Description("完成连接日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ConnectDate;
    /// <summary>
    /// 完成连接时间
    /// </summary>
    [Description("完成连接时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ConnectTime;
    /// <summary>
    /// 启动日期
    /// </summary>
    [Description("启动日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String StartDate;
    /// <summary>
    /// 启动时间
    /// </summary>
    [Description("启动时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String StartTime;
    /// <summary>
    /// 交易日
    /// </summary>
    [Description("交易日")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradingDay;
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 营业部编号
    /// </summary>
    [Description("营业部编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String BranchID;

  };

  /// <summary>
  /// 投资者结算结果
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcSettlementInfoField
  {
    /// <summary>
    /// 交易日
    /// </summary>
    [Description("交易日")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradingDay;
    /// <summary>
    /// 结算编号
    /// </summary>
    [Description("结算编号")]
    public int SettlementID;
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 序号
    /// </summary>
    [Description("序号")]
    public int SequenceNo;
    /// <summary>
    /// 消息正文
    /// </summary>
    [Description("消息正文")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 501)]
    public String Content;

  };

  /// <summary>
  /// 合约保证金率调整
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcInstrumentMarginRateAdjustField
  {
    /// <summary>
    /// 合约代码
    /// </summary>
    [Description("合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String InstrumentID;
    /// <summary>
    /// 投资者范围
    /// </summary>
    [Description("投资者范围")]
    public CTPStockInvestorRangeType InvestorRange;
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 投机套保标志
    /// </summary>
    [Description("投机套保标志")]
    public CTPStockHedgeFlagType HedgeFlag;
    /// <summary>
    /// 多头保证金率
    /// </summary>
    [Description("多头保证金率")]
    public double LongMarginRatioByMoney;
    /// <summary>
    /// 多头保证金费
    /// </summary>
    [Description("多头保证金费")]
    public double LongMarginRatioByVolume;
    /// <summary>
    /// 空头保证金率
    /// </summary>
    [Description("空头保证金率")]
    public double ShortMarginRatioByMoney;
    /// <summary>
    /// 空头保证金费
    /// </summary>
    [Description("空头保证金费")]
    public double ShortMarginRatioByVolume;
    /// <summary>
    /// 是否相对交易所收取
    /// </summary>
    [Description("是否相对交易所收取")]
    public bool IsRelative;

  };

  /// <summary>
  /// 交易所保证金率
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcExchangeMarginRateField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 合约代码
    /// </summary>
    [Description("合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String InstrumentID;
    /// <summary>
    /// 投机套保标志
    /// </summary>
    [Description("投机套保标志")]
    public CTPStockHedgeFlagType HedgeFlag;
    /// <summary>
    /// 多头保证金率
    /// </summary>
    [Description("多头保证金率")]
    public double LongMarginRatioByMoney;
    /// <summary>
    /// 多头保证金费
    /// </summary>
    [Description("多头保证金费")]
    public double LongMarginRatioByVolume;
    /// <summary>
    /// 空头保证金率
    /// </summary>
    [Description("空头保证金率")]
    public double ShortMarginRatioByMoney;
    /// <summary>
    /// 空头保证金费
    /// </summary>
    [Description("空头保证金费")]
    public double ShortMarginRatioByVolume;

  };

  /// <summary>
  /// 交易所保证金率调整
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcExchangeMarginRateAdjustField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 合约代码
    /// </summary>
    [Description("合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String InstrumentID;
    /// <summary>
    /// 投机套保标志
    /// </summary>
    [Description("投机套保标志")]
    public CTPStockHedgeFlagType HedgeFlag;
    /// <summary>
    /// 跟随交易所投资者多头保证金率
    /// </summary>
    [Description("跟随交易所投资者多头保证金率")]
    public double LongMarginRatioByMoney;
    /// <summary>
    /// 跟随交易所投资者多头保证金费
    /// </summary>
    [Description("跟随交易所投资者多头保证金费")]
    public double LongMarginRatioByVolume;
    /// <summary>
    /// 跟随交易所投资者空头保证金率
    /// </summary>
    [Description("跟随交易所投资者空头保证金率")]
    public double ShortMarginRatioByMoney;
    /// <summary>
    /// 跟随交易所投资者空头保证金费
    /// </summary>
    [Description("跟随交易所投资者空头保证金费")]
    public double ShortMarginRatioByVolume;
    /// <summary>
    /// 交易所多头保证金率
    /// </summary>
    [Description("交易所多头保证金率")]
    public double ExchLongMarginRatioByMoney;
    /// <summary>
    /// 交易所多头保证金费
    /// </summary>
    [Description("交易所多头保证金费")]
    public double ExchLongMarginRatioByVolume;
    /// <summary>
    /// 交易所空头保证金率
    /// </summary>
    [Description("交易所空头保证金率")]
    public double ExchShortMarginRatioByMoney;
    /// <summary>
    /// 交易所空头保证金费
    /// </summary>
    [Description("交易所空头保证金费")]
    public double ExchShortMarginRatioByVolume;
    /// <summary>
    /// 不跟随交易所投资者多头保证金率
    /// </summary>
    [Description("不跟随交易所投资者多头保证金率")]
    public double NoLongMarginRatioByMoney;
    /// <summary>
    /// 不跟随交易所投资者多头保证金费
    /// </summary>
    [Description("不跟随交易所投资者多头保证金费")]
    public double NoLongMarginRatioByVolume;
    /// <summary>
    /// 不跟随交易所投资者空头保证金率
    /// </summary>
    [Description("不跟随交易所投资者空头保证金率")]
    public double NoShortMarginRatioByMoney;
    /// <summary>
    /// 不跟随交易所投资者空头保证金费
    /// </summary>
    [Description("不跟随交易所投资者空头保证金费")]
    public double NoShortMarginRatioByVolume;

  };

  /// <summary>
  /// 结算引用
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcSettlementRefField
  {
    /// <summary>
    /// 交易日
    /// </summary>
    [Description("交易日")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradingDay;
    /// <summary>
    /// 结算编号
    /// </summary>
    [Description("结算编号")]
    public int SettlementID;

  };

  /// <summary>
  /// 当前时间
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcCurrentTimeField
  {
    /// <summary>
    /// 当前日期
    /// </summary>
    [Description("当前日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String CurrDate;
    /// <summary>
    /// 当前时间
    /// </summary>
    [Description("当前时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String CurrTime;
    /// <summary>
    /// 当前时间（毫秒）
    /// </summary>
    [Description("当前时间（毫秒）")]
    public int CurrMillisec;

  };

  /// <summary>
  /// 通讯阶段
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcCommPhaseField
  {
    /// <summary>
    /// 交易日
    /// </summary>
    [Description("交易日")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradingDay;
    /// <summary>
    /// 通讯时段编号
    /// </summary>
    [Description("通讯时段编号")]
    public short CommPhaseNo;

  };

  /// <summary>
  /// 登录信息
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcLoginInfoField
  {
    /// <summary>
    /// 前置编号
    /// </summary>
    [Description("前置编号")]
    public int FrontID;
    /// <summary>
    /// 会话编号
    /// </summary>
    [Description("会话编号")]
    public int SessionID;
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 用户代码
    /// </summary>
    [Description("用户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;
    /// <summary>
    /// 登录日期
    /// </summary>
    [Description("登录日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String LoginDate;
    /// <summary>
    /// 登录时间
    /// </summary>
    [Description("登录时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String LoginTime;
    /// <summary>
    /// IP地址
    /// </summary>
    [Description("IP地址")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String IPAddress;
    /// <summary>
    /// 用户端产品信息
    /// </summary>
    [Description("用户端产品信息")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String UserProductInfo;
    /// <summary>
    /// 接口端产品信息
    /// </summary>
    [Description("接口端产品信息")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String InterfaceProductInfo;
    /// <summary>
    /// 协议信息
    /// </summary>
    [Description("协议信息")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String ProtocolInfo;
    /// <summary>
    /// 系统名称
    /// </summary>
    [Description("系统名称")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String SystemName;
    /// <summary>
    /// 密码
    /// </summary>
    [Description("密码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String Password;
    /// <summary>
    /// 最大报单引用
    /// </summary>
    [Description("最大报单引用")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String MaxOrderRef;
    /// <summary>
    /// Mac地址
    /// </summary>
    [Description("Mac地址")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String MacAddress;
    /// <summary>
    /// 动态密码
    /// </summary>
    [Description("动态密码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String OneTimePassword;

  };

  /// <summary>
  /// 登录信息
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcLogoutAllField
  {
    /// <summary>
    /// 前置编号
    /// </summary>
    [Description("前置编号")]
    public int FrontID;
    /// <summary>
    /// 会话编号
    /// </summary>
    [Description("会话编号")]
    public int SessionID;
    /// <summary>
    /// 系统名称
    /// </summary>
    [Description("系统名称")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String SystemName;

  };

  /// <summary>
  /// 前置状态
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcFrontStatusField
  {
    /// <summary>
    /// 前置编号
    /// </summary>
    [Description("前置编号")]
    public int FrontID;
    /// <summary>
    /// 上次报告日期
    /// </summary>
    [Description("上次报告日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String LastReportDate;
    /// <summary>
    /// 上次报告时间
    /// </summary>
    [Description("上次报告时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String LastReportTime;
    /// <summary>
    /// 是否活跃
    /// </summary>
    [Description("是否活跃")]
    public bool IsActive;

  };

  /// <summary>
  /// 用户口令变更
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcUserPasswordUpdateField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 用户代码
    /// </summary>
    [Description("用户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;
    /// <summary>
    /// 原来的口令
    /// </summary>
    [Description("原来的口令")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String OldPassword;
    /// <summary>
    /// 新的口令
    /// </summary>
    [Description("新的口令")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String NewPassword;

  };

  /// <summary>
  /// 输入报单
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcInputOrderField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 合约代码
    /// </summary>
    [Description("合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String InstrumentID;
    /// <summary>
    /// 报单引用
    /// </summary>
    [Description("报单引用")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String OrderRef;
    /// <summary>
    /// 用户代码
    /// </summary>
    [Description("用户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;
    /// <summary>
    /// 报单价格条件
    /// </summary>
    [Description("报单价格条件")]
    public CTPStockOrderPriceType OrderPriceType;
    /// <summary>
    /// 买卖方向
    /// </summary>
    [Description("买卖方向")]
    public CTPStockDirectionType Direction;
    /// <summary>
    /// 组合开平标志
    /// </summary>
    [Description("组合开平标志")]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
    public byte[] CombOffsetFlag;
    /// <summary>
    /// 组合投机套保标志
    /// </summary>
    [Description("组合投机套保标志")]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
    public byte[] CombHedgeFlag;
    /// <summary>
    /// 价格
    /// </summary>
    [Description("价格")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String LimitPrice;
    /// <summary>
    /// 数量
    /// </summary>
    [Description("数量")]
    public int VolumeTotalOriginal;
    /// <summary>
    /// 有效期类型
    /// </summary>
    [Description("有效期类型")]
    public CTPStockTimeConditionType TimeCondition;
    /// <summary>
    /// GTD日期
    /// </summary>
    [Description("GTD日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String GTDDate;
    /// <summary>
    /// 成交量类型
    /// </summary>
    [Description("成交量类型")]
    public CTPStockVolumeConditionType VolumeCondition;
    /// <summary>
    /// 最小成交量
    /// </summary>
    [Description("最小成交量")]
    public int MinVolume;
    /// <summary>
    /// 触发条件
    /// </summary>
    [Description("触发条件")]
    public CTPStockContingentConditionType ContingentCondition;
    /// <summary>
    /// 止损价
    /// </summary>
    [Description("止损价")]
    public double StopPrice;
    /// <summary>
    /// 强平原因
    /// </summary>
    [Description("强平原因")]
    public CTPStockForceCloseReasonType ForceCloseReason;
    /// <summary>
    /// 自动挂起标志
    /// </summary>
    [Description("自动挂起标志")]
    public bool IsAutoSuspend;
    /// <summary>
    /// 业务单元
    /// </summary>
    [Description("业务单元")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String BusinessUnit;
    /// <summary>
    /// 请求编号
    /// </summary>
    [Description("请求编号")]
    public int RequestID;
    /// <summary>
    /// 用户强评标志
    /// </summary>
    [Description("用户强评标志")]
    public bool UserForceClose;

  };

  /// <summary>
  /// 报单
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcOrderField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 合约代码
    /// </summary>
    [Description("合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String InstrumentID;
    /// <summary>
    /// 报单引用
    /// </summary>
    [Description("报单引用")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String OrderRef;
    /// <summary>
    /// 用户代码
    /// </summary>
    [Description("用户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;
    /// <summary>
    /// 报单价格条件
    /// </summary>
    [Description("报单价格条件")]
    public CTPStockOrderPriceType OrderPriceType;
    /// <summary>
    /// 买卖方向
    /// </summary>
    [Description("买卖方向")]
    public CTPStockDirectionType Direction;
    /// <summary>
    /// 组合开平标志
    /// </summary>
    [Description("组合开平标志")]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
    public byte[] CombOffsetFlag;
    /// <summary>
    /// 组合投机套保标志
    /// </summary>
    [Description("组合投机套保标志")]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
    public byte[] CombHedgeFlag;
    /// <summary>
    /// 价格
    /// </summary>
    [Description("价格")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String LimitPrice;
    /// <summary>
    /// 数量
    /// </summary>
    [Description("数量")]
    public int VolumeTotalOriginal;
    /// <summary>
    /// 有效期类型
    /// </summary>
    [Description("有效期类型")]
    public CTPStockTimeConditionType TimeCondition;
    /// <summary>
    /// GTD日期
    /// </summary>
    [Description("GTD日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String GTDDate;
    /// <summary>
    /// 成交量类型
    /// </summary>
    [Description("成交量类型")]
    public CTPStockVolumeConditionType VolumeCondition;
    /// <summary>
    /// 最小成交量
    /// </summary>
    [Description("最小成交量")]
    public int MinVolume;
    /// <summary>
    /// 触发条件
    /// </summary>
    [Description("触发条件")]
    public CTPStockContingentConditionType ContingentCondition;
    /// <summary>
    /// 止损价
    /// </summary>
    [Description("止损价")]
    public double StopPrice;
    /// <summary>
    /// 强平原因
    /// </summary>
    [Description("强平原因")]
    public CTPStockForceCloseReasonType ForceCloseReason;
    /// <summary>
    /// 自动挂起标志
    /// </summary>
    [Description("自动挂起标志")]
    public bool IsAutoSuspend;
    /// <summary>
    /// 业务单元
    /// </summary>
    [Description("业务单元")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String BusinessUnit;
    /// <summary>
    /// 请求编号
    /// </summary>
    [Description("请求编号")]
    public int RequestID;
    /// <summary>
    /// 本地报单编号
    /// </summary>
    [Description("本地报单编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String OrderLocalID;
    /// <summary>
    /// 会员代码
    /// </summary>
    [Description("会员代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String ParticipantID;
    /// <summary>
    /// 客户代码
    /// </summary>
    [Description("客户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String ClientID;
    /// <summary>
    /// 合约在交易所的代码
    /// </summary>
    [Description("合约在交易所的代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String ExchangeInstID;
    /// <summary>
    /// 交易所交易员代码
    /// </summary>
    [Description("交易所交易员代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String TraderID;
    /// <summary>
    /// 安装编号
    /// </summary>
    [Description("安装编号")]
    public int InstallID;
    /// <summary>
    /// 报单提交状态
    /// </summary>
    [Description("报单提交状态")]
    public CTPStockOrderSubmitStatusType OrderSubmitStatus;
    /// <summary>
    /// 报单提示序号
    /// </summary>
    [Description("报单提示序号")]
    public int NotifySequence;
    /// <summary>
    /// 交易日
    /// </summary>
    [Description("交易日")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradingDay;
    /// <summary>
    /// 结算编号
    /// </summary>
    [Description("结算编号")]
    public int SettlementID;
    /// <summary>
    /// 报单编号
    /// </summary>
    [Description("报单编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String OrderSysID;
    /// <summary>
    /// 报单来源
    /// </summary>
    [Description("报单来源")]
    public CTPStockOrderSourceType OrderSource;
    /// <summary>
    /// 报单状态
    /// </summary>
    [Description("报单状态")]
    public CTPStockOrderStatusType OrderStatus;
    /// <summary>
    /// 报单类型
    /// </summary>
    [Description("报单类型")]
    public CTPStockOrderType OrderType;
    /// <summary>
    /// 今成交数量
    /// </summary>
    [Description("今成交数量")]
    public int VolumeTraded;
    /// <summary>
    /// 剩余数量
    /// </summary>
    [Description("剩余数量")]
    public int VolumeTotal;
    /// <summary>
    /// 报单日期
    /// </summary>
    [Description("报单日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String InsertDate;
    /// <summary>
    /// 委托时间
    /// </summary>
    [Description("委托时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String InsertTime;
    /// <summary>
    /// 激活时间
    /// </summary>
    [Description("激活时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ActiveTime;
    /// <summary>
    /// 挂起时间
    /// </summary>
    [Description("挂起时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String SuspendTime;
    /// <summary>
    /// 最后修改时间
    /// </summary>
    [Description("最后修改时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String UpdateTime;
    /// <summary>
    /// 撤销时间
    /// </summary>
    [Description("撤销时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String CancelTime;
    /// <summary>
    /// 最后修改交易所交易员代码
    /// </summary>
    [Description("最后修改交易所交易员代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String ActiveTraderID;
    /// <summary>
    /// 结算会员编号
    /// </summary>
    [Description("结算会员编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String ClearingPartID;
    /// <summary>
    /// 序号
    /// </summary>
    [Description("序号")]
    public int SequenceNo;
    /// <summary>
    /// 前置编号
    /// </summary>
    [Description("前置编号")]
    public int FrontID;
    /// <summary>
    /// 会话编号
    /// </summary>
    [Description("会话编号")]
    public int SessionID;
    /// <summary>
    /// 用户端产品信息
    /// </summary>
    [Description("用户端产品信息")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String UserProductInfo;
    /// <summary>
    /// 状态信息
    /// </summary>
    [Description("状态信息")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
    public String StatusMsg;
    /// <summary>
    /// 用户强评标志
    /// </summary>
    [Description("用户强评标志")]
    public bool UserForceClose;
    /// <summary>
    /// 操作用户代码
    /// </summary>
    [Description("操作用户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String ActiveUserID;
    /// <summary>
    /// 经纪公司报单编号
    /// </summary>
    [Description("经纪公司报单编号")]
    public int BrokerOrderSeq;
    /// <summary>
    /// 相关报单
    /// </summary>
    [Description("相关报单")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String RelativeOrderSysID;
    /// <summary>
    /// 营业部编号
    /// </summary>
    [Description("营业部编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String BranchID;
    /// <summary>
    /// 成交数量
    /// </summary>
    [Description("成交数量")]
    public double TradeAmount;
    /// <summary>
    /// 是否ETF
    /// </summary>
    [Description("是否ETF")]
    public bool IsETF;
    /// <summary>
    /// 资金帐号
    /// </summary>
    [Description("资金帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String AccountID;

  };

  /// <summary>
  /// 交易所报单
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcExchangeOrderField
  {
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;
    /// <summary>
    /// 报单价格条件
    /// </summary>
    [Description("报单价格条件")]
    public CTPStockOrderPriceType OrderPriceType;
    /// <summary>
    /// 买卖方向
    /// </summary>
    [Description("买卖方向")]
    public CTPStockDirectionType Direction;
    /// <summary>
    /// 组合开平标志
    /// </summary>
    [Description("组合开平标志")]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
    public byte[] CombOffsetFlag;
    /// <summary>
    /// 组合投机套保标志
    /// </summary>
    [Description("组合投机套保标志")]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
    public byte[] CombHedgeFlag;
    /// <summary>
    /// 价格
    /// </summary>
    [Description("价格")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String LimitPrice;
    /// <summary>
    /// 数量
    /// </summary>
    [Description("数量")]
    public int VolumeTotalOriginal;
    /// <summary>
    /// 有效期类型
    /// </summary>
    [Description("有效期类型")]
    public CTPStockTimeConditionType TimeCondition;
    /// <summary>
    /// GTD日期
    /// </summary>
    [Description("GTD日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String GTDDate;
    /// <summary>
    /// 成交量类型
    /// </summary>
    [Description("成交量类型")]
    public CTPStockVolumeConditionType VolumeCondition;
    /// <summary>
    /// 最小成交量
    /// </summary>
    [Description("最小成交量")]
    public int MinVolume;
    /// <summary>
    /// 触发条件
    /// </summary>
    [Description("触发条件")]
    public CTPStockContingentConditionType ContingentCondition;
    /// <summary>
    /// 止损价
    /// </summary>
    [Description("止损价")]
    public double StopPrice;
    /// <summary>
    /// 强平原因
    /// </summary>
    [Description("强平原因")]
    public CTPStockForceCloseReasonType ForceCloseReason;
    /// <summary>
    /// 自动挂起标志
    /// </summary>
    [Description("自动挂起标志")]
    public bool IsAutoSuspend;
    /// <summary>
    /// 业务单元
    /// </summary>
    [Description("业务单元")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String BusinessUnit;
    /// <summary>
    /// 请求编号
    /// </summary>
    [Description("请求编号")]
    public int RequestID;
    /// <summary>
    /// 本地报单编号
    /// </summary>
    [Description("本地报单编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String OrderLocalID;
    /// <summary>
    /// 会员代码
    /// </summary>
    [Description("会员代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String ParticipantID;
    /// <summary>
    /// 客户代码
    /// </summary>
    [Description("客户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String ClientID;
    /// <summary>
    /// 合约在交易所的代码
    /// </summary>
    [Description("合约在交易所的代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String ExchangeInstID;
    /// <summary>
    /// 交易所交易员代码
    /// </summary>
    [Description("交易所交易员代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String TraderID;
    /// <summary>
    /// 安装编号
    /// </summary>
    [Description("安装编号")]
    public int InstallID;
    /// <summary>
    /// 报单提交状态
    /// </summary>
    [Description("报单提交状态")]
    public CTPStockOrderSubmitStatusType OrderSubmitStatus;
    /// <summary>
    /// 报单提示序号
    /// </summary>
    [Description("报单提示序号")]
    public int NotifySequence;
    /// <summary>
    /// 交易日
    /// </summary>
    [Description("交易日")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradingDay;
    /// <summary>
    /// 结算编号
    /// </summary>
    [Description("结算编号")]
    public int SettlementID;
    /// <summary>
    /// 报单编号
    /// </summary>
    [Description("报单编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String OrderSysID;
    /// <summary>
    /// 报单来源
    /// </summary>
    [Description("报单来源")]
    public CTPStockOrderSourceType OrderSource;
    /// <summary>
    /// 报单状态
    /// </summary>
    [Description("报单状态")]
    public CTPStockOrderStatusType OrderStatus;
    /// <summary>
    /// 报单类型
    /// </summary>
    [Description("报单类型")]
    public CTPStockOrderType OrderType;
    /// <summary>
    /// 今成交数量
    /// </summary>
    [Description("今成交数量")]
    public int VolumeTraded;
    /// <summary>
    /// 剩余数量
    /// </summary>
    [Description("剩余数量")]
    public int VolumeTotal;
    /// <summary>
    /// 报单日期
    /// </summary>
    [Description("报单日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String InsertDate;
    /// <summary>
    /// 委托时间
    /// </summary>
    [Description("委托时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String InsertTime;
    /// <summary>
    /// 激活时间
    /// </summary>
    [Description("激活时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ActiveTime;
    /// <summary>
    /// 挂起时间
    /// </summary>
    [Description("挂起时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String SuspendTime;
    /// <summary>
    /// 最后修改时间
    /// </summary>
    [Description("最后修改时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String UpdateTime;
    /// <summary>
    /// 撤销时间
    /// </summary>
    [Description("撤销时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String CancelTime;
    /// <summary>
    /// 最后修改交易所交易员代码
    /// </summary>
    [Description("最后修改交易所交易员代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String ActiveTraderID;
    /// <summary>
    /// 结算会员编号
    /// </summary>
    [Description("结算会员编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String ClearingPartID;
    /// <summary>
    /// 序号
    /// </summary>
    [Description("序号")]
    public int SequenceNo;
    /// <summary>
    /// 营业部编号
    /// </summary>
    [Description("营业部编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String BranchID;

  };

  /// <summary>
  /// 交易所报单插入失败
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcExchangeOrderInsertErrorField
  {
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;
    /// <summary>
    /// 会员代码
    /// </summary>
    [Description("会员代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String ParticipantID;
    /// <summary>
    /// 交易所交易员代码
    /// </summary>
    [Description("交易所交易员代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String TraderID;
    /// <summary>
    /// 安装编号
    /// </summary>
    [Description("安装编号")]
    public int InstallID;
    /// <summary>
    /// 本地报单编号
    /// </summary>
    [Description("本地报单编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String OrderLocalID;
    /// <summary>
    /// 错误代码
    /// </summary>
    [Description("错误代码")]
    public int ErrorID;
    /// <summary>
    /// 错误信息
    /// </summary>
    [Description("错误信息")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
    public String ErrorMsg;

  };

  /// <summary>
  /// 输入报单操作
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcInputOrderActionField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 报单操作引用
    /// </summary>
    [Description("报单操作引用")]
    public int OrderActionRef;
    /// <summary>
    /// 报单引用
    /// </summary>
    [Description("报单引用")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String OrderRef;
    /// <summary>
    /// 请求编号
    /// </summary>
    [Description("请求编号")]
    public int RequestID;
    /// <summary>
    /// 前置编号
    /// </summary>
    [Description("前置编号")]
    public int FrontID;
    /// <summary>
    /// 会话编号
    /// </summary>
    [Description("会话编号")]
    public int SessionID;
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;
    /// <summary>
    /// 操作标志
    /// </summary>
    [Description("操作标志")]
    public CTPStockActionFlagType ActionFlag;
    /// <summary>
    /// 价格
    /// </summary>
    [Description("价格")]
    public double LimitPrice;
    /// <summary>
    /// 数量变化
    /// </summary>
    [Description("数量变化")]
    public int VolumeChange;
    /// <summary>
    /// 用户代码
    /// </summary>
    [Description("用户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;
    /// <summary>
    /// 合约代码
    /// </summary>
    [Description("合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String InstrumentID;
    /// <summary>
    /// 交易所交易员代码
    /// </summary>
    [Description("交易所交易员代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String TraderID;
    /// <summary>
    /// 本地报单编号
    /// </summary>
    [Description("本地报单编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String OrderLocalID;

  };

  /// <summary>
  /// 报单操作
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcOrderActionField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 报单操作引用
    /// </summary>
    [Description("报单操作引用")]
    public int OrderActionRef;
    /// <summary>
    /// 报单引用
    /// </summary>
    [Description("报单引用")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String OrderRef;
    /// <summary>
    /// 请求编号
    /// </summary>
    [Description("请求编号")]
    public int RequestID;
    /// <summary>
    /// 前置编号
    /// </summary>
    [Description("前置编号")]
    public int FrontID;
    /// <summary>
    /// 会话编号
    /// </summary>
    [Description("会话编号")]
    public int SessionID;
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;
    /// <summary>
    /// 操作标志
    /// </summary>
    [Description("操作标志")]
    public CTPStockActionFlagType ActionFlag;
    /// <summary>
    /// 价格
    /// </summary>
    [Description("价格")]
    public double LimitPrice;
    /// <summary>
    /// 数量变化
    /// </summary>
    [Description("数量变化")]
    public int VolumeChange;
    /// <summary>
    /// 操作日期
    /// </summary>
    [Description("操作日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ActionDate;
    /// <summary>
    /// 操作时间
    /// </summary>
    [Description("操作时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ActionTime;
    /// <summary>
    /// 交易所交易员代码
    /// </summary>
    [Description("交易所交易员代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String TraderID;
    /// <summary>
    /// 安装编号
    /// </summary>
    [Description("安装编号")]
    public int InstallID;
    /// <summary>
    /// 本地报单编号
    /// </summary>
    [Description("本地报单编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String OrderLocalID;
    /// <summary>
    /// 操作本地编号
    /// </summary>
    [Description("操作本地编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String ActionLocalID;
    /// <summary>
    /// 会员代码
    /// </summary>
    [Description("会员代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String ParticipantID;
    /// <summary>
    /// 客户代码
    /// </summary>
    [Description("客户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String ClientID;
    /// <summary>
    /// 业务单元
    /// </summary>
    [Description("业务单元")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String BusinessUnit;
    /// <summary>
    /// 报单操作状态
    /// </summary>
    [Description("报单操作状态")]
    public CTPStockOrderActionStatusType OrderActionStatus;
    /// <summary>
    /// 用户代码
    /// </summary>
    [Description("用户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;
    /// <summary>
    /// 营业部编号
    /// </summary>
    [Description("营业部编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String BranchID;
    /// <summary>
    /// 状态信息
    /// </summary>
    [Description("状态信息")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
    public String StatusMsg;
    /// <summary>
    /// 合约代码
    /// </summary>
    [Description("合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String InstrumentID;

  };

  /// <summary>
  /// 交易所报单操作
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcExchangeOrderActionField
  {
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;
    /// <summary>
    /// 操作标志
    /// </summary>
    [Description("操作标志")]
    public CTPStockActionFlagType ActionFlag;
    /// <summary>
    /// 价格
    /// </summary>
    [Description("价格")]
    public double LimitPrice;
    /// <summary>
    /// 数量变化
    /// </summary>
    [Description("数量变化")]
    public int VolumeChange;
    /// <summary>
    /// 操作日期
    /// </summary>
    [Description("操作日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ActionDate;
    /// <summary>
    /// 操作时间
    /// </summary>
    [Description("操作时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ActionTime;
    /// <summary>
    /// 交易所交易员代码
    /// </summary>
    [Description("交易所交易员代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String TraderID;
    /// <summary>
    /// 安装编号
    /// </summary>
    [Description("安装编号")]
    public int InstallID;
    /// <summary>
    /// 本地报单编号
    /// </summary>
    [Description("本地报单编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String OrderLocalID;
    /// <summary>
    /// 操作本地编号
    /// </summary>
    [Description("操作本地编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String ActionLocalID;
    /// <summary>
    /// 会员代码
    /// </summary>
    [Description("会员代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String ParticipantID;
    /// <summary>
    /// 客户代码
    /// </summary>
    [Description("客户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String ClientID;
    /// <summary>
    /// 业务单元
    /// </summary>
    [Description("业务单元")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String BusinessUnit;
    /// <summary>
    /// 报单操作状态
    /// </summary>
    [Description("报单操作状态")]
    public CTPStockOrderActionStatusType OrderActionStatus;
    /// <summary>
    /// 用户代码
    /// </summary>
    [Description("用户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;
    /// <summary>
    /// 营业部编号
    /// </summary>
    [Description("营业部编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String BranchID;

  };

  /// <summary>
  /// 交易所报单操作失败
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcExchangeOrderActionErrorField
  {
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;
    /// <summary>
    /// 报单编号
    /// </summary>
    [Description("报单编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String OrderSysID;
    /// <summary>
    /// 交易所交易员代码
    /// </summary>
    [Description("交易所交易员代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String TraderID;
    /// <summary>
    /// 安装编号
    /// </summary>
    [Description("安装编号")]
    public int InstallID;
    /// <summary>
    /// 本地报单编号
    /// </summary>
    [Description("本地报单编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String OrderLocalID;
    /// <summary>
    /// 操作本地编号
    /// </summary>
    [Description("操作本地编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String ActionLocalID;
    /// <summary>
    /// 错误代码
    /// </summary>
    [Description("错误代码")]
    public int ErrorID;
    /// <summary>
    /// 错误信息
    /// </summary>
    [Description("错误信息")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
    public String ErrorMsg;

  };

  /// <summary>
  /// 交易所成交
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcExchangeTradeField
  {
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;
    /// <summary>
    /// 成交编号
    /// </summary>
    [Description("成交编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String TradeID;
    /// <summary>
    /// 买卖方向
    /// </summary>
    [Description("买卖方向")]
    public CTPStockDirectionType Direction;
    /// <summary>
    /// 报单编号
    /// </summary>
    [Description("报单编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String OrderSysID;
    /// <summary>
    /// 会员代码
    /// </summary>
    [Description("会员代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String ParticipantID;
    /// <summary>
    /// 客户代码
    /// </summary>
    [Description("客户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String ClientID;
    /// <summary>
    /// 交易角色
    /// </summary>
    [Description("交易角色")]
    public CTPStockTradingRoleType TradingRole;
    /// <summary>
    /// 合约在交易所的代码
    /// </summary>
    [Description("合约在交易所的代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String ExchangeInstID;
    /// <summary>
    /// 开平标志
    /// </summary>
    [Description("开平标志")]
    public CTPStockOffsetFlagType OffsetFlag;
    /// <summary>
    /// 投机套保标志
    /// </summary>
    [Description("投机套保标志")]
    public CTPStockHedgeFlagType HedgeFlag;
    /// <summary>
    /// 价格
    /// </summary>
    [Description("价格")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String Price;
    /// <summary>
    /// 数量
    /// </summary>
    [Description("数量")]
    public int Volume;
    /// <summary>
    /// 成交时期
    /// </summary>
    [Description("成交时期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeDate;
    /// <summary>
    /// 成交时间
    /// </summary>
    [Description("成交时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeTime;
    /// <summary>
    /// 成交类型
    /// </summary>
    [Description("成交类型")]
    public CTPStockTradeType TradeType;
    /// <summary>
    /// 成交价来源
    /// </summary>
    [Description("成交价来源")]
    public CTPStockPriceSourceType PriceSource;
    /// <summary>
    /// 交易所交易员代码
    /// </summary>
    [Description("交易所交易员代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String TraderID;
    /// <summary>
    /// 本地报单编号
    /// </summary>
    [Description("本地报单编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String OrderLocalID;
    /// <summary>
    /// 结算会员编号
    /// </summary>
    [Description("结算会员编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String ClearingPartID;
    /// <summary>
    /// 业务单元
    /// </summary>
    [Description("业务单元")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String BusinessUnit;
    /// <summary>
    /// 序号
    /// </summary>
    [Description("序号")]
    public int SequenceNo;

  };

  /// <summary>
  /// 成交
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcTradeField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 合约代码
    /// </summary>
    [Description("合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String InstrumentID;
    /// <summary>
    /// 报单引用
    /// </summary>
    [Description("报单引用")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String OrderRef;
    /// <summary>
    /// 用户代码
    /// </summary>
    [Description("用户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;
    /// <summary>
    /// 成交编号
    /// </summary>
    [Description("成交编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String TradeID;
    /// <summary>
    /// 买卖方向
    /// </summary>
    [Description("买卖方向")]
    public CTPStockDirectionType Direction;
    /// <summary>
    /// 报单编号
    /// </summary>
    [Description("报单编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String OrderSysID;
    /// <summary>
    /// 会员代码
    /// </summary>
    [Description("会员代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String ParticipantID;
    /// <summary>
    /// 客户代码
    /// </summary>
    [Description("客户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String ClientID;
    /// <summary>
    /// 交易角色
    /// </summary>
    [Description("交易角色")]
    public CTPStockTradingRoleType TradingRole;
    /// <summary>
    /// 合约在交易所的代码
    /// </summary>
    [Description("合约在交易所的代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String ExchangeInstID;
    /// <summary>
    /// 开平标志
    /// </summary>
    [Description("开平标志")]
    public CTPStockOffsetFlagType OffsetFlag;
    /// <summary>
    /// 投机套保标志
    /// </summary>
    [Description("投机套保标志")]
    public CTPStockHedgeFlagType HedgeFlag;
    /// <summary>
    /// 价格
    /// </summary>
    [Description("价格")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String Price;
    /// <summary>
    /// 数量
    /// </summary>
    [Description("数量")]
    public int Volume;
    /// <summary>
    /// 成交时期
    /// </summary>
    [Description("成交时期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeDate;
    /// <summary>
    /// 成交时间
    /// </summary>
    [Description("成交时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeTime;
    /// <summary>
    /// 成交类型
    /// </summary>
    [Description("成交类型")]
    public CTPStockTradeType TradeType;
    /// <summary>
    /// 成交价来源
    /// </summary>
    [Description("成交价来源")]
    public CTPStockPriceSourceType PriceSource;
    /// <summary>
    /// 交易所交易员代码
    /// </summary>
    [Description("交易所交易员代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String TraderID;
    /// <summary>
    /// 本地报单编号
    /// </summary>
    [Description("本地报单编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String OrderLocalID;
    /// <summary>
    /// 结算会员编号
    /// </summary>
    [Description("结算会员编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String ClearingPartID;
    /// <summary>
    /// 业务单元
    /// </summary>
    [Description("业务单元")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String BusinessUnit;
    /// <summary>
    /// 序号
    /// </summary>
    [Description("序号")]
    public int SequenceNo;
    /// <summary>
    /// 交易日
    /// </summary>
    [Description("交易日")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradingDay;
    /// <summary>
    /// 结算编号
    /// </summary>
    [Description("结算编号")]
    public int SettlementID;
    /// <summary>
    /// 经纪公司报单编号
    /// </summary>
    [Description("经纪公司报单编号")]
    public int BrokerOrderSeq;

  };

  /// <summary>
  /// 用户会话
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcUserSessionField
  {
    /// <summary>
    /// 前置编号
    /// </summary>
    [Description("前置编号")]
    public int FrontID;
    /// <summary>
    /// 会话编号
    /// </summary>
    [Description("会话编号")]
    public int SessionID;
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 用户代码
    /// </summary>
    [Description("用户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;
    /// <summary>
    /// 登录日期
    /// </summary>
    [Description("登录日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String LoginDate;
    /// <summary>
    /// 登录时间
    /// </summary>
    [Description("登录时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String LoginTime;
    /// <summary>
    /// IP地址
    /// </summary>
    [Description("IP地址")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String IPAddress;
    /// <summary>
    /// 用户端产品信息
    /// </summary>
    [Description("用户端产品信息")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String UserProductInfo;
    /// <summary>
    /// 接口端产品信息
    /// </summary>
    [Description("接口端产品信息")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String InterfaceProductInfo;
    /// <summary>
    /// 协议信息
    /// </summary>
    [Description("协议信息")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String ProtocolInfo;
    /// <summary>
    /// Mac地址
    /// </summary>
    [Description("Mac地址")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String MacAddress;

  };

  /// <summary>
  /// 查询最大报单数量
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQueryMaxOrderVolumeField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 合约代码
    /// </summary>
    [Description("合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String InstrumentID;
    /// <summary>
    /// 买卖方向
    /// </summary>
    [Description("买卖方向")]
    public CTPStockDirectionType Direction;
    /// <summary>
    /// 开平标志
    /// </summary>
    [Description("开平标志")]
    public CTPStockOffsetFlagType OffsetFlag;
    /// <summary>
    /// 投机套保标志
    /// </summary>
    [Description("投机套保标志")]
    public CTPStockHedgeFlagType HedgeFlag;
    /// <summary>
    /// 最大允许报单数量
    /// </summary>
    [Description("最大允许报单数量")]
    public int MaxVolume;

  };

  /// <summary>
  /// 投资者结算结果确认信息
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcSettlementInfoConfirmField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 确认日期
    /// </summary>
    [Description("确认日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ConfirmDate;
    /// <summary>
    /// 确认时间
    /// </summary>
    [Description("确认时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ConfirmTime;

  };

  /// <summary>
  /// 出入金同步
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcSyncDepositField
  {
    /// <summary>
    /// 出入金流水号
    /// </summary>
    [Description("出入金流水号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String DepositSeqNo;
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 入金金额
    /// </summary>
    [Description("入金金额")]
    public double Deposit;
    /// <summary>
    /// 是否强制进行
    /// </summary>
    [Description("是否强制进行")]
    public bool IsForce;

  };

  /// <summary>
  /// 经纪公司同步
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcBrokerSyncField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;

  };

  /// <summary>
  /// 正在同步中的投资者
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcSyncingInvestorField
  {
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者分组代码
    /// </summary>
    [Description("投资者分组代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorGroupID;
    /// <summary>
    /// 投资者名称
    /// </summary>
    [Description("投资者名称")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
    public String InvestorName;
    /// <summary>
    /// 证件类型
    /// </summary>
    [Description("证件类型")]
    public CTPStockIdCardType IdentifiedCardType;
    /// <summary>
    /// 证件号码
    /// </summary>
    [Description("证件号码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
    public String IdentifiedCardNo;
    /// <summary>
    /// 是否活跃
    /// </summary>
    [Description("是否活跃")]
    public bool IsActive;
    /// <summary>
    /// 联系电话
    /// </summary>
    [Description("联系电话")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String Telephone;
    /// <summary>
    /// 通讯地址
    /// </summary>
    [Description("通讯地址")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
    public String Address;
    /// <summary>
    /// 开户日期
    /// </summary>
    [Description("开户日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String OpenDate;
    /// <summary>
    /// 手机
    /// </summary>
    [Description("手机")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String Mobile;
    /// <summary>
    /// 上海营业部编号
    /// </summary>
    [Description("上海营业部编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String SHBranchID;
    /// <summary>
    /// 深圳营业部编号
    /// </summary>
    [Description("深圳营业部编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String SZBranchID;
    /// <summary>
    /// 是否信用账户
    /// </summary>
    [Description("是否信用账户")]
    public bool IsCreditAccount;

  };

  /// <summary>
  /// 正在同步中的交易代码
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcSyncingTradingCodeField
  {
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;
    /// <summary>
    /// 客户代码
    /// </summary>
    [Description("客户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String ClientID;
    /// <summary>
    /// 是否活跃
    /// </summary>
    [Description("是否活跃")]
    public bool IsActive;

  };

  /// <summary>
  /// 正在同步中的投资者分组
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcSyncingInvestorGroupField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者分组代码
    /// </summary>
    [Description("投资者分组代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorGroupID;
    /// <summary>
    /// 投资者分组名称
    /// </summary>
    [Description("投资者分组名称")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String InvestorGroupName;

  };

  /// <summary>
  /// 正在同步中的交易账号
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcSyncingTradingAccountField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者帐号
    /// </summary>
    [Description("投资者帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String AccountID;
    /// <summary>
    /// 上次质押金额
    /// </summary>
    [Description("上次质押金额")]
    public double PreMortgage;
    /// <summary>
    /// 上次信用额度
    /// </summary>
    [Description("上次信用额度")]
    public double PreCredit;
    /// <summary>
    /// 上次存款额
    /// </summary>
    [Description("上次存款额")]
    public double PreDeposit;
    /// <summary>
    /// 上次结算准备金
    /// </summary>
    [Description("上次结算准备金")]
    public double PreBalance;
    /// <summary>
    /// 上次占用的保证金
    /// </summary>
    [Description("上次占用的保证金")]
    public double PreMargin;
    /// <summary>
    /// 利息基数
    /// </summary>
    [Description("利息基数")]
    public double InterestBase;
    /// <summary>
    /// 利息收入
    /// </summary>
    [Description("利息收入")]
    public double Interest;
    /// <summary>
    /// 入金金额
    /// </summary>
    [Description("入金金额")]
    public double Deposit;
    /// <summary>
    /// 出金金额
    /// </summary>
    [Description("出金金额")]
    public double Withdraw;
    /// <summary>
    /// 冻结的保证金
    /// </summary>
    [Description("冻结的保证金")]
    public double FrozenMargin;
    /// <summary>
    /// 冻结的资金
    /// </summary>
    [Description("冻结的资金")]
    public double FrozenCash;
    /// <summary>
    /// 冻结的手续费
    /// </summary>
    [Description("冻结的手续费")]
    public double FrozenCommission;
    /// <summary>
    /// 当前保证金总额
    /// </summary>
    [Description("当前保证金总额")]
    public double CurrMargin;
    /// <summary>
    /// 资金差额
    /// </summary>
    [Description("资金差额")]
    public double CashIn;
    /// <summary>
    /// 手续费
    /// </summary>
    [Description("手续费")]
    public double Commission;
    /// <summary>
    /// 平仓盈亏
    /// </summary>
    [Description("平仓盈亏")]
    public double CloseProfit;
    /// <summary>
    /// 持仓盈亏
    /// </summary>
    [Description("持仓盈亏")]
    public double PositionProfit;
    /// <summary>
    /// 期货结算准备金
    /// </summary>
    [Description("期货结算准备金")]
    public double Balance;
    /// <summary>
    /// 可用资金
    /// </summary>
    [Description("可用资金")]
    public double Available;
    /// <summary>
    /// 可取资金
    /// </summary>
    [Description("可取资金")]
    public double WithdrawQuota;
    /// <summary>
    /// 基本准备金
    /// </summary>
    [Description("基本准备金")]
    public double Reserve;
    /// <summary>
    /// 交易日
    /// </summary>
    [Description("交易日")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradingDay;
    /// <summary>
    /// 结算编号
    /// </summary>
    [Description("结算编号")]
    public int SettlementID;
    /// <summary>
    /// 信用额度
    /// </summary>
    [Description("信用额度")]
    public double Credit;
    /// <summary>
    /// 质押金额
    /// </summary>
    [Description("质押金额")]
    public double Mortgage;
    /// <summary>
    /// 交易所保证金
    /// </summary>
    [Description("交易所保证金")]
    public double ExchangeMargin;
    /// <summary>
    /// 投资者交割保证金
    /// </summary>
    [Description("投资者交割保证金")]
    public double DeliveryMargin;
    /// <summary>
    /// 交易所交割保证金
    /// </summary>
    [Description("交易所交割保证金")]
    public double ExchangeDeliveryMargin;
    /// <summary>
    /// 冻结的过户费
    /// </summary>
    [Description("冻结的过户费")]
    public double FrozenTransferFee;
    /// <summary>
    /// 冻结的印花税
    /// </summary>
    [Description("冻结的印花税")]
    public double FrozenStampTax;
    /// <summary>
    /// 过户费
    /// </summary>
    [Description("过户费")]
    public double TransferFee;
    /// <summary>
    /// 印花税
    /// </summary>
    [Description("印花税")]
    public double StampTax;
    /// <summary>
    /// 折算金额
    /// </summary>
    [Description("折算金额")]
    public double ConversionAmount;
    /// <summary>
    /// 授信额度
    /// </summary>
    [Description("授信额度")]
    public double CreditAmount;
    /// <summary>
    /// 最低维持担保比例
    /// </summary>
    [Description("最低维持担保比例")]
    public double LowLimitRatio;
    /// <summary>
    /// 融资买入金额
    /// </summary>
    [Description("融资买入金额")]
    public double MarginTradingAmount;
    /// <summary>
    /// 融券卖出金额
    /// </summary>
    [Description("融券卖出金额")]
    public double ShortSellingAmount;
    /// <summary>
    /// 融资买入可用金额
    /// </summary>
    [Description("融资买入可用金额")]
    public double MarginTradingAvail;
    /// <summary>
    /// 融券卖出可用金额
    /// </summary>
    [Description("融券卖出可用金额")]
    public double ShortSellingAvail;
    /// <summary>
    /// 维持担保比例
    /// </summary>
    [Description("维持担保比例")]
    public double CreditRatio;
    /// <summary>
    /// 证券总价值
    /// </summary>
    [Description("证券总价值")]
    public double StockValue;

  };

  /// <summary>
  /// 正在同步中的投资者持仓
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcSyncingInvestorPositionField
  {
    /// <summary>
    /// 合约代码
    /// </summary>
    [Description("合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String InstrumentID;
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 持仓多空方向
    /// </summary>
    [Description("持仓多空方向")]
    public CTPStockPosiDirectionType PosiDirection;
    /// <summary>
    /// 投机套保标志
    /// </summary>
    [Description("投机套保标志")]
    public CTPStockHedgeFlagType HedgeFlag;
    /// <summary>
    /// 持仓日期
    /// </summary>
    [Description("持仓日期")]
    public CTPStockPositionDateType PositionDate;
    /// <summary>
    /// 上日持仓
    /// </summary>
    [Description("上日持仓")]
    public int YdPosition;
    /// <summary>
    /// 今日持仓
    /// </summary>
    [Description("今日持仓")]
    public int Position;
    /// <summary>
    /// 多头冻结
    /// </summary>
    [Description("多头冻结")]
    public int LongFrozen;
    /// <summary>
    /// 空头冻结
    /// </summary>
    [Description("空头冻结")]
    public int ShortFrozen;
    /// <summary>
    /// 开仓冻结金额
    /// </summary>
    [Description("开仓冻结金额")]
    public double LongFrozenAmount;
    /// <summary>
    /// 开仓冻结金额
    /// </summary>
    [Description("开仓冻结金额")]
    public double ShortFrozenAmount;
    /// <summary>
    /// 开仓量
    /// </summary>
    [Description("开仓量")]
    public int OpenVolume;
    /// <summary>
    /// 平仓量
    /// </summary>
    [Description("平仓量")]
    public int CloseVolume;
    /// <summary>
    /// 开仓金额
    /// </summary>
    [Description("开仓金额")]
    public double OpenAmount;
    /// <summary>
    /// 平仓金额
    /// </summary>
    [Description("平仓金额")]
    public double CloseAmount;
    /// <summary>
    /// 持仓成本
    /// </summary>
    [Description("持仓成本")]
    public double PositionCost;
    /// <summary>
    /// 冻结的资金
    /// </summary>
    [Description("冻结的资金")]
    public double FrozenCash;
    /// <summary>
    /// 资金差额
    /// </summary>
    [Description("资金差额")]
    public double CashIn;
    /// <summary>
    /// 手续费
    /// </summary>
    [Description("手续费")]
    public double Commission;
    /// <summary>
    /// 平仓盈亏
    /// </summary>
    [Description("平仓盈亏")]
    public double CloseProfit;
    /// <summary>
    /// 持仓盈亏
    /// </summary>
    [Description("持仓盈亏")]
    public double PositionProfit;
    /// <summary>
    /// 上次结算价
    /// </summary>
    [Description("上次结算价")]
    public double PreSettlementPrice;
    /// <summary>
    /// 本次结算价
    /// </summary>
    [Description("本次结算价")]
    public double SettlementPrice;
    /// <summary>
    /// 交易日
    /// </summary>
    [Description("交易日")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradingDay;
    /// <summary>
    /// 结算编号
    /// </summary>
    [Description("结算编号")]
    public int SettlementID;
    /// <summary>
    /// 开仓成本
    /// </summary>
    [Description("开仓成本")]
    public double OpenCost;
    /// <summary>
    /// 交易所保证金
    /// </summary>
    [Description("交易所保证金")]
    public double ExchangeMargin;
    /// <summary>
    /// 今日持仓
    /// </summary>
    [Description("今日持仓")]
    public int TodayPosition;
    /// <summary>
    /// 过户费
    /// </summary>
    [Description("过户费")]
    public double TransferFee;
    /// <summary>
    /// 印花税
    /// </summary>
    [Description("印花税")]
    public double StampTax;
    /// <summary>
    /// 今日申购赎回数量
    /// </summary>
    [Description("今日申购赎回数量")]
    public int TodayPurRedVolume;
    /// <summary>
    /// 折算率
    /// </summary>
    [Description("折算率")]
    public double ConversionRate;
    /// <summary>
    /// 折算金额
    /// </summary>
    [Description("折算金额")]
    public double ConversionAmount;
    /// <summary>
    /// 融资买入出数量
    /// </summary>
    [Description("融资买入出数量")]
    public int MarginTradeVolume;
    /// <summary>
    /// 融资买入金额
    /// </summary>
    [Description("融资买入金额")]
    public double MarginTradeAmount;
    /// <summary>
    /// 融资买入冻结数量
    /// </summary>
    [Description("融资买入冻结数量")]
    public int MarginTradeFrozenVolume;
    /// <summary>
    /// 融资买入冻结金额
    /// </summary>
    [Description("融资买入冻结金额")]
    public double MarginTradeFrozenAmount;
    /// <summary>
    /// 融资买入折算金额
    /// </summary>
    [Description("融资买入折算金额")]
    public double MarginTradeConversionAmount;
    /// <summary>
    /// 融券卖出数量
    /// </summary>
    [Description("融券卖出数量")]
    public int ShortSellVolume;
    /// <summary>
    /// 融券卖出金额
    /// </summary>
    [Description("融券卖出金额")]
    public double ShortSellAmount;
    /// <summary>
    /// 融券卖出折算金额
    /// </summary>
    [Description("融券卖出折算金额")]
    public double ShortSellConversionAmount;
    /// <summary>
    /// 融券卖出冻结数量
    /// </summary>
    [Description("融券卖出冻结数量")]
    public int ShortSellFrozenVolume;
    /// <summary>
    /// 融券卖出冻结金额
    /// </summary>
    [Description("融券卖出冻结金额")]
    public double ShortSellFrozenAmount;
    /// <summary>
    /// 证券价值
    /// </summary>
    [Description("证券价值")]
    public double StockValue;
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;

  };

  /// <summary>
  /// 正在同步中的合约保证金率
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcSyncingInstrumentMarginRateField
  {
    /// <summary>
    /// 合约代码
    /// </summary>
    [Description("合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String InstrumentID;
    /// <summary>
    /// 投资者范围
    /// </summary>
    [Description("投资者范围")]
    public CTPStockInvestorRangeType InvestorRange;
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 投机套保标志
    /// </summary>
    [Description("投机套保标志")]
    public CTPStockHedgeFlagType HedgeFlag;
    /// <summary>
    /// 多头保证金率
    /// </summary>
    [Description("多头保证金率")]
    public double LongMarginRatioByMoney;
    /// <summary>
    /// 多头保证金费
    /// </summary>
    [Description("多头保证金费")]
    public double LongMarginRatioByVolume;
    /// <summary>
    /// 空头保证金率
    /// </summary>
    [Description("空头保证金率")]
    public double ShortMarginRatioByMoney;
    /// <summary>
    /// 空头保证金费
    /// </summary>
    [Description("空头保证金费")]
    public double ShortMarginRatioByVolume;
    /// <summary>
    /// 是否相对交易所收取
    /// </summary>
    [Description("是否相对交易所收取")]
    public bool IsRelative;

  };

  /// <summary>
  /// 正在同步中的合约手续费率
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcSyncingInstrumentCommissionRateField
  {
    /// <summary>
    /// 合约代码
    /// </summary>
    [Description("合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String InstrumentID;
    /// <summary>
    /// 投资者范围
    /// </summary>
    [Description("投资者范围")]
    public CTPStockInvestorRangeType InvestorRange;
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 买印花税率
    /// </summary>
    [Description("买印花税率")]
    public double BuyStampTaxRateByMoney;
    /// <summary>
    /// 买印花税率(按手数)
    /// </summary>
    [Description("买印花税率(按手数)")]
    public double BuyStampTaxRateByVolume;
    /// <summary>
    /// 卖印花税率
    /// </summary>
    [Description("卖印花税率")]
    public double SellStampTaxRateByMoney;
    /// <summary>
    /// 卖印花税率(按手数)
    /// </summary>
    [Description("卖印花税率(按手数)")]
    public double SellStampTaxRateByVolume;
    /// <summary>
    /// 买过户费率
    /// </summary>
    [Description("买过户费率")]
    public double BuyTransferFeeRateByMoney;
    /// <summary>
    /// 买过户费率(按手数)
    /// </summary>
    [Description("买过户费率(按手数)")]
    public double BuyTransferFeeRateByVolume;
    /// <summary>
    /// 卖过户费率
    /// </summary>
    [Description("卖过户费率")]
    public double SellTransferFeeRateByMoney;
    /// <summary>
    /// 卖过户费率(按手数)
    /// </summary>
    [Description("卖过户费率(按手数)")]
    public double SellTransferFeeRateByVolume;
    /// <summary>
    /// 买交易费
    /// </summary>
    [Description("买交易费")]
    public double BuyTradeFeeByMoney;
    /// <summary>
    /// 买交易费(按手数)
    /// </summary>
    [Description("买交易费(按手数)")]
    public double BuyTradeFeeByVolume;
    /// <summary>
    /// 卖交易费率
    /// </summary>
    [Description("卖交易费率")]
    public double SellTradeFeeByMoney;
    /// <summary>
    /// 卖交易费率(按手数)
    /// </summary>
    [Description("卖交易费率(按手数)")]
    public double SellTradeFeeByVolume;
    /// <summary>
    /// 买交易附加费率
    /// </summary>
    [Description("买交易附加费率")]
    public double BuyMarginByMoney;
    /// <summary>
    /// 卖交易附加费率
    /// </summary>
    [Description("卖交易附加费率")]
    public double SellMarginByMoney;
    /// <summary>
    /// 最小过户费
    /// </summary>
    [Description("最小过户费")]
    public double MinTradeFee;

  };

  /// <summary>
  /// 正在同步中的合约交易权限
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcSyncingInstrumentTradingRightField
  {
    /// <summary>
    /// 合约代码
    /// </summary>
    [Description("合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String InstrumentID;
    /// <summary>
    /// 投资者范围
    /// </summary>
    [Description("投资者范围")]
    public CTPStockInvestorRangeType InvestorRange;
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 买卖
    /// </summary>
    [Description("买卖")]
    public CTPStockDirectionType Direction;
    /// <summary>
    /// 交易权限
    /// </summary>
    [Description("交易权限")]
    public CTPStockTradingRightType TradingRight;
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;

  };

  /// <summary>
  /// 查询报单
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQryOrderField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 合约代码
    /// </summary>
    [Description("合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String InstrumentID;
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;
    /// <summary>
    /// 报单编号
    /// </summary>
    [Description("报单编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String OrderSysID;
    /// <summary>
    /// 开始时间
    /// </summary>
    [Description("开始时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String InsertTimeStart;
    /// <summary>
    /// 结束时间
    /// </summary>
    [Description("结束时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String InsertTimeEnd;

  };

  /// <summary>
  /// 查询成交
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQryTradeField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 合约代码
    /// </summary>
    [Description("合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String InstrumentID;
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;
    /// <summary>
    /// 成交编号
    /// </summary>
    [Description("成交编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String TradeID;
    /// <summary>
    /// 开始时间
    /// </summary>
    [Description("开始时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeTimeStart;
    /// <summary>
    /// 结束时间
    /// </summary>
    [Description("结束时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeTimeEnd;

  };

  /// <summary>
  /// 查询投资者持仓
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQryInvestorPositionField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 合约代码
    /// </summary>
    [Description("合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String InstrumentID;

  };

  /// <summary>
  /// 查询资金账户
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQryTradingAccountField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;

  };

  /// <summary>
  /// 查询投资者
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQryInvestorField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;

  };

  /// <summary>
  /// 查询交易编码
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQryTradingCodeField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;
    /// <summary>
    /// 客户代码
    /// </summary>
    [Description("客户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String ClientID;

  };

  /// <summary>
  /// 查询交易编码
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQryInvestorGroupField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;

  };

  /// <summary>
  /// 查询交易编码
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQryInstrumentMarginRateField
  {
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 合约代码
    /// </summary>
    [Description("合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String InstrumentID;
    /// <summary>
    /// 投机套保标志
    /// </summary>
    [Description("投机套保标志")]
    public CTPStockHedgeFlagType HedgeFlag;

  };

  /// <summary>
  /// 查询交易编码
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQryInstrumentCommissionRateField
  {
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 合约代码
    /// </summary>
    [Description("合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String InstrumentID;

  };

  /// <summary>
  /// 查询交易编码
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQryInstrumentTradingRightField
  {
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 合约代码
    /// </summary>
    [Description("合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String InstrumentID;

  };

  /// <summary>
  /// 查询经纪公司
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQryBrokerField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;

  };

  /// <summary>
  /// 查询交易员
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQryTraderField
  {
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;
    /// <summary>
    /// 会员代码
    /// </summary>
    [Description("会员代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String ParticipantID;
    /// <summary>
    /// 交易所交易员代码
    /// </summary>
    [Description("交易所交易员代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String TraderID;

  };

  /// <summary>
  /// 查询经纪公司会员代码
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQryPartBrokerField
  {
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 会员代码
    /// </summary>
    [Description("会员代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String ParticipantID;

  };

  /// <summary>
  /// 查询管理用户功能权限
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQrySuperUserFunctionField
  {
    /// <summary>
    /// 用户代码
    /// </summary>
    [Description("用户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;

  };

  /// <summary>
  /// 查询用户会话
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQryUserSessionField
  {
    /// <summary>
    /// 前置编号
    /// </summary>
    [Description("前置编号")]
    public int FrontID;
    /// <summary>
    /// 会话编号
    /// </summary>
    [Description("会话编号")]
    public int SessionID;
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 用户代码
    /// </summary>
    [Description("用户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;

  };

  /// <summary>
  /// 查询前置状态
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQryFrontStatusField
  {
    /// <summary>
    /// 前置编号
    /// </summary>
    [Description("前置编号")]
    public int FrontID;

  };

  /// <summary>
  /// 查询交易所报单
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQryExchangeOrderField
  {
    /// <summary>
    /// 会员代码
    /// </summary>
    [Description("会员代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String ParticipantID;
    /// <summary>
    /// 客户代码
    /// </summary>
    [Description("客户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String ClientID;
    /// <summary>
    /// 合约在交易所的代码
    /// </summary>
    [Description("合约在交易所的代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String ExchangeInstID;
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;
    /// <summary>
    /// 交易所交易员代码
    /// </summary>
    [Description("交易所交易员代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String TraderID;

  };

  /// <summary>
  /// 查询报单操作
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQryOrderActionField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;

  };

  /// <summary>
  /// 查询交易所报单操作
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQryExchangeOrderActionField
  {
    /// <summary>
    /// 会员代码
    /// </summary>
    [Description("会员代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String ParticipantID;
    /// <summary>
    /// 客户代码
    /// </summary>
    [Description("客户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String ClientID;
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;
    /// <summary>
    /// 交易所交易员代码
    /// </summary>
    [Description("交易所交易员代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String TraderID;

  };

  /// <summary>
  /// 查询管理用户
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQrySuperUserField
  {
    /// <summary>
    /// 用户代码
    /// </summary>
    [Description("用户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;

  };

  /// <summary>
  /// 查询交易所
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQryExchangeField
  {
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;

  };

  /// <summary>
  /// 查询产品
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQryProductField
  {
    /// <summary>
    /// 产品代码
    /// </summary>
    [Description("产品代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String ProductID;

  };

  /// <summary>
  /// 查询合约
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQryInstrumentField
  {
    /// <summary>
    /// 合约代码
    /// </summary>
    [Description("合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String InstrumentID;
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;
    /// <summary>
    /// 合约在交易所的代码
    /// </summary>
    [Description("合约在交易所的代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String ExchangeInstID;
    /// <summary>
    /// 产品代码
    /// </summary>
    [Description("产品代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String ProductID;

  };

  /// <summary>
  /// 查询行情
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQryDepthMarketDataField
  {
    /// <summary>
    /// 合约代码
    /// </summary>
    [Description("合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String InstrumentID;

  };

  /// <summary>
  /// 查询经纪公司用户
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQryBrokerUserField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 用户代码
    /// </summary>
    [Description("用户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;

  };

  /// <summary>
  /// 查询经纪公司用户权限
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQryBrokerUserFunctionField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 用户代码
    /// </summary>
    [Description("用户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;

  };

  /// <summary>
  /// 查询交易员报盘机
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQryTraderOfferField
  {
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;
    /// <summary>
    /// 会员代码
    /// </summary>
    [Description("会员代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String ParticipantID;
    /// <summary>
    /// 交易所交易员代码
    /// </summary>
    [Description("交易所交易员代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String TraderID;

  };

  /// <summary>
  /// 查询出入金流水
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQrySyncDepositField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 出入金流水号
    /// </summary>
    [Description("出入金流水号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String DepositSeqNo;

  };

  /// <summary>
  /// 查询投资者结算结果
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQrySettlementInfoField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 交易日
    /// </summary>
    [Description("交易日")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradingDay;

  };

  /// <summary>
  /// 查询报单
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQryHisOrderField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 合约代码
    /// </summary>
    [Description("合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String InstrumentID;
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;
    /// <summary>
    /// 报单编号
    /// </summary>
    [Description("报单编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String OrderSysID;
    /// <summary>
    /// 开始时间
    /// </summary>
    [Description("开始时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String InsertTimeStart;
    /// <summary>
    /// 结束时间
    /// </summary>
    [Description("结束时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String InsertTimeEnd;
    /// <summary>
    /// 交易日
    /// </summary>
    [Description("交易日")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradingDay;
    /// <summary>
    /// 结算编号
    /// </summary>
    [Description("结算编号")]
    public int SettlementID;

  };

  /// <summary>
  /// 市场行情
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcMarketDataField
  {
    /// <summary>
    /// 交易日
    /// </summary>
    [Description("交易日")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradingDay;
    /// <summary>
    /// 合约代码
    /// </summary>
    [Description("合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String InstrumentID;
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;
    /// <summary>
    /// 合约在交易所的代码
    /// </summary>
    [Description("合约在交易所的代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String ExchangeInstID;
    /// <summary>
    /// 最新价
    /// </summary>
    [Description("最新价")]
    public double LastPrice;
    /// <summary>
    /// 上次结算价
    /// </summary>
    [Description("上次结算价")]
    public double PreSettlementPrice;
    /// <summary>
    /// 昨收盘
    /// </summary>
    [Description("昨收盘")]
    public double PreClosePrice;
    /// <summary>
    /// 昨持仓量
    /// </summary>
    [Description("昨持仓量")]
    public double PreOpenInterest;
    /// <summary>
    /// 今开盘
    /// </summary>
    [Description("今开盘")]
    public double OpenPrice;
    /// <summary>
    /// 最高价
    /// </summary>
    [Description("最高价")]
    public double HighestPrice;
    /// <summary>
    /// 最低价
    /// </summary>
    [Description("最低价")]
    public double LowestPrice;
    /// <summary>
    /// 数量
    /// </summary>
    [Description("数量")]
    public int Volume;
    /// <summary>
    /// 成交金额
    /// </summary>
    [Description("成交金额")]
    public double Turnover;
    /// <summary>
    /// 持仓量
    /// </summary>
    [Description("持仓量")]
    public double OpenInterest;
    /// <summary>
    /// 今收盘
    /// </summary>
    [Description("今收盘")]
    public double ClosePrice;
    /// <summary>
    /// 本次结算价
    /// </summary>
    [Description("本次结算价")]
    public double SettlementPrice;
    /// <summary>
    /// 涨停板价
    /// </summary>
    [Description("涨停板价")]
    public double UpperLimitPrice;
    /// <summary>
    /// 跌停板价
    /// </summary>
    [Description("跌停板价")]
    public double LowerLimitPrice;
    /// <summary>
    /// 昨虚实度
    /// </summary>
    [Description("昨虚实度")]
    public double PreDelta;
    /// <summary>
    /// 今虚实度
    /// </summary>
    [Description("今虚实度")]
    public double CurrDelta;
    /// <summary>
    /// 最后修改时间
    /// </summary>
    [Description("最后修改时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String UpdateTime;
    /// <summary>
    /// 最后修改毫秒
    /// </summary>
    [Description("最后修改毫秒")]
    public int UpdateMillisec;

  };

  /// <summary>
  /// 行情基础属性
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcMarketDataBaseField
  {
    /// <summary>
    /// 交易日
    /// </summary>
    [Description("交易日")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradingDay;
    /// <summary>
    /// 上次结算价
    /// </summary>
    [Description("上次结算价")]
    public double PreSettlementPrice;
    /// <summary>
    /// 昨收盘
    /// </summary>
    [Description("昨收盘")]
    public double PreClosePrice;
    /// <summary>
    /// 昨持仓量
    /// </summary>
    [Description("昨持仓量")]
    public double PreOpenInterest;
    /// <summary>
    /// 昨虚实度
    /// </summary>
    [Description("昨虚实度")]
    public double PreDelta;

  };

  /// <summary>
  /// 行情静态属性
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcMarketDataStaticField
  {
    /// <summary>
    /// 今开盘
    /// </summary>
    [Description("今开盘")]
    public double OpenPrice;
    /// <summary>
    /// 最高价
    /// </summary>
    [Description("最高价")]
    public double HighestPrice;
    /// <summary>
    /// 最低价
    /// </summary>
    [Description("最低价")]
    public double LowestPrice;
    /// <summary>
    /// 今收盘
    /// </summary>
    [Description("今收盘")]
    public double ClosePrice;
    /// <summary>
    /// 涨停板价
    /// </summary>
    [Description("涨停板价")]
    public double UpperLimitPrice;
    /// <summary>
    /// 跌停板价
    /// </summary>
    [Description("跌停板价")]
    public double LowerLimitPrice;
    /// <summary>
    /// 本次结算价
    /// </summary>
    [Description("本次结算价")]
    public double SettlementPrice;
    /// <summary>
    /// 今虚实度
    /// </summary>
    [Description("今虚实度")]
    public double CurrDelta;

  };

  /// <summary>
  /// 行情最新成交属性
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcMarketDataLastMatchField
  {
    /// <summary>
    /// 最新价
    /// </summary>
    [Description("最新价")]
    public double LastPrice;
    /// <summary>
    /// 数量
    /// </summary>
    [Description("数量")]
    public int Volume;
    /// <summary>
    /// 成交金额
    /// </summary>
    [Description("成交金额")]
    public double Turnover;
    /// <summary>
    /// 持仓量
    /// </summary>
    [Description("持仓量")]
    public double OpenInterest;

  };

  /// <summary>
  /// 行情最优价属性
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcMarketDataBestPriceField
  {
    /// <summary>
    /// 申买价一
    /// </summary>
    [Description("申买价一")]
    public double BidPrice1;
    /// <summary>
    /// 申买量一
    /// </summary>
    [Description("申买量一")]
    public int BidVolume1;
    /// <summary>
    /// 申卖价一
    /// </summary>
    [Description("申卖价一")]
    public double AskPrice1;
    /// <summary>
    /// 申卖量一
    /// </summary>
    [Description("申卖量一")]
    public int AskVolume1;

  };

  /// <summary>
  /// 行情申买二、三属性
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcMarketDataBid23Field
  {
    /// <summary>
    /// 申买价二
    /// </summary>
    [Description("申买价二")]
    public double BidPrice2;
    /// <summary>
    /// 申买量二
    /// </summary>
    [Description("申买量二")]
    public int BidVolume2;
    /// <summary>
    /// 申买价三
    /// </summary>
    [Description("申买价三")]
    public double BidPrice3;
    /// <summary>
    /// 申买量三
    /// </summary>
    [Description("申买量三")]
    public int BidVolume3;

  };

  /// <summary>
  /// 行情申卖二、三属性
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcMarketDataAsk23Field
  {
    /// <summary>
    /// 申卖价二
    /// </summary>
    [Description("申卖价二")]
    public double AskPrice2;
    /// <summary>
    /// 申卖量二
    /// </summary>
    [Description("申卖量二")]
    public int AskVolume2;
    /// <summary>
    /// 申卖价三
    /// </summary>
    [Description("申卖价三")]
    public double AskPrice3;
    /// <summary>
    /// 申卖量三
    /// </summary>
    [Description("申卖量三")]
    public int AskVolume3;

  };

  /// <summary>
  /// 行情申买四、五属性
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcMarketDataBid45Field
  {
    /// <summary>
    /// 申买价四
    /// </summary>
    [Description("申买价四")]
    public double BidPrice4;
    /// <summary>
    /// 申买量四
    /// </summary>
    [Description("申买量四")]
    public int BidVolume4;
    /// <summary>
    /// 申买价五
    /// </summary>
    [Description("申买价五")]
    public double BidPrice5;
    /// <summary>
    /// 申买量五
    /// </summary>
    [Description("申买量五")]
    public int BidVolume5;

  };

  /// <summary>
  /// 行情申卖四、五属性
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcMarketDataAsk45Field
  {
    /// <summary>
    /// 申卖价四
    /// </summary>
    [Description("申卖价四")]
    public double AskPrice4;
    /// <summary>
    /// 申卖量四
    /// </summary>
    [Description("申卖量四")]
    public int AskVolume4;
    /// <summary>
    /// 申卖价五
    /// </summary>
    [Description("申卖价五")]
    public double AskPrice5;
    /// <summary>
    /// 申卖量五
    /// </summary>
    [Description("申卖量五")]
    public int AskVolume5;

  };

  /// <summary>
  /// 行情更新时间属性
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcMarketDataUpdateTimeField
  {
    /// <summary>
    /// 合约代码
    /// </summary>
    [Description("合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String InstrumentID;
    /// <summary>
    /// 最后修改时间
    /// </summary>
    [Description("最后修改时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String UpdateTime;
    /// <summary>
    /// 最后修改毫秒
    /// </summary>
    [Description("最后修改毫秒")]
    public int UpdateMillisec;

  };

  /// <summary>
  /// 指定的合约
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcSpecificInstrumentField
  {
    /// <summary>
    /// 合约代码
    /// </summary>
    [Description("合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String InstrumentID;
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;

  };

  /// <summary>
  /// 合约状态
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcInstrumentStatusField
  {
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;
    /// <summary>
    /// 合约在交易所的代码
    /// </summary>
    [Description("合约在交易所的代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String ExchangeInstID;
    /// <summary>
    /// 结算组代码
    /// </summary>
    [Description("结算组代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String SettlementGroupID;
    /// <summary>
    /// 合约代码
    /// </summary>
    [Description("合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String InstrumentID;
    /// <summary>
    /// 合约交易状态
    /// </summary>
    [Description("合约交易状态")]
    public CTPStockInstrumentStatusType InstrumentStatus;
    /// <summary>
    /// 交易阶段编号
    /// </summary>
    [Description("交易阶段编号")]
    public int TradingSegmentSN;
    /// <summary>
    /// 进入本状态时间
    /// </summary>
    [Description("进入本状态时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String EnterTime;
    /// <summary>
    /// 进入本状态原因
    /// </summary>
    [Description("进入本状态原因")]
    public CTPStockInstStatusEnterReasonType EnterReason;

  };

  /// <summary>
  /// 查询合约状态
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQryInstrumentStatusField
  {
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;
    /// <summary>
    /// 合约在交易所的代码
    /// </summary>
    [Description("合约在交易所的代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String ExchangeInstID;

  };

  /// <summary>
  /// 投资者账户
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcInvestorAccountField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 投资者帐号
    /// </summary>
    [Description("投资者帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String AccountID;

  };

  /// <summary>
  /// 浮动盈亏算法
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcPositionProfitAlgorithmField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者帐号
    /// </summary>
    [Description("投资者帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String AccountID;
    /// <summary>
    /// 盈亏算法
    /// </summary>
    [Description("盈亏算法")]
    public CTPStockAlgorithmType Algorithm;
    /// <summary>
    /// 备注
    /// </summary>
    [Description("备注")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
    public String Memo;

  };

  /// <summary>
  /// 会员资金折扣
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcDiscountField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者范围
    /// </summary>
    [Description("投资者范围")]
    public CTPStockInvestorRangeType InvestorRange;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 资金折扣比例
    /// </summary>
    [Description("资金折扣比例")]
    public double Discount;

  };

  /// <summary>
  /// 查询转帐银行
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQryTransferBankField
  {
    /// <summary>
    /// 银行代码
    /// </summary>
    [Description("银行代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String BankID;
    /// <summary>
    /// 银行分中心代码
    /// </summary>
    [Description("银行分中心代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public String BankBrchID;

  };

  /// <summary>
  /// 转帐银行
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcTransferBankField
  {
    /// <summary>
    /// 银行代码
    /// </summary>
    [Description("银行代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String BankID;
    /// <summary>
    /// 银行分中心代码
    /// </summary>
    [Description("银行分中心代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public String BankBrchID;
    /// <summary>
    /// 银行名称
    /// </summary>
    [Description("银行名称")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
    public String BankName;
    /// <summary>
    /// 是否活跃
    /// </summary>
    [Description("是否活跃")]
    public bool IsActive;

  };

  /// <summary>
  /// 查询投资者持仓明细
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQryInvestorPositionDetailField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 合约代码
    /// </summary>
    [Description("合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String InstrumentID;

  };

  /// <summary>
  /// 投资者持仓明细
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcInvestorPositionDetailField
  {
    /// <summary>
    /// 合约代码
    /// </summary>
    [Description("合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String InstrumentID;
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 投机套保标志
    /// </summary>
    [Description("投机套保标志")]
    public CTPStockHedgeFlagType HedgeFlag;
    /// <summary>
    /// 买卖
    /// </summary>
    [Description("买卖")]
    public CTPStockDirectionType Direction;
    /// <summary>
    /// 开仓日期
    /// </summary>
    [Description("开仓日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String OpenDate;
    /// <summary>
    /// 成交编号
    /// </summary>
    [Description("成交编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String TradeID;
    /// <summary>
    /// 数量
    /// </summary>
    [Description("数量")]
    public int Volume;
    /// <summary>
    /// 开仓价
    /// </summary>
    [Description("开仓价")]
    public double OpenPrice;
    /// <summary>
    /// 交易日
    /// </summary>
    [Description("交易日")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradingDay;
    /// <summary>
    /// 结算编号
    /// </summary>
    [Description("结算编号")]
    public int SettlementID;
    /// <summary>
    /// 成交类型
    /// </summary>
    [Description("成交类型")]
    public CTPStockTradeType TradeType;
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;
    /// <summary>
    /// 投资者保证金
    /// </summary>
    [Description("投资者保证金")]
    public double Margin;
    /// <summary>
    /// 交易所保证金
    /// </summary>
    [Description("交易所保证金")]
    public double ExchMargin;
    /// <summary>
    /// 昨结算价
    /// </summary>
    [Description("昨结算价")]
    public double LastSettlementPrice;
    /// <summary>
    /// 结算价
    /// </summary>
    [Description("结算价")]
    public double SettlementPrice;
    /// <summary>
    /// 平仓量
    /// </summary>
    [Description("平仓量")]
    public int CloseVolume;
    /// <summary>
    /// 平仓金额
    /// </summary>
    [Description("平仓金额")]
    public double CloseAmount;
    /// <summary>
    /// 过户费
    /// </summary>
    [Description("过户费")]
    public double TransferFee;
    /// <summary>
    /// 印花税
    /// </summary>
    [Description("印花税")]
    public double StampTax;
    /// <summary>
    /// 手续费
    /// </summary>
    [Description("手续费")]
    public double Commission;

  };

  /// <summary>
  /// 资金账户口令域
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcTradingAccountPasswordField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者帐号
    /// </summary>
    [Description("投资者帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String AccountID;
    /// <summary>
    /// 密码
    /// </summary>
    [Description("密码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String Password;

  };

  /// <summary>
  /// 交易所行情报盘机
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcMDTraderOfferField
  {
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;
    /// <summary>
    /// 交易所交易员代码
    /// </summary>
    [Description("交易所交易员代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String TraderID;
    /// <summary>
    /// 会员代码
    /// </summary>
    [Description("会员代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String ParticipantID;
    /// <summary>
    /// 密码
    /// </summary>
    [Description("密码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String Password;
    /// <summary>
    /// 安装编号
    /// </summary>
    [Description("安装编号")]
    public int InstallID;
    /// <summary>
    /// 本地报单编号
    /// </summary>
    [Description("本地报单编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String OrderLocalID;
    /// <summary>
    /// 交易所交易员连接状态
    /// </summary>
    [Description("交易所交易员连接状态")]
    public CTPStockTraderConnectStatusType TraderConnectStatus;
    /// <summary>
    /// 发出连接请求的日期
    /// </summary>
    [Description("发出连接请求的日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ConnectRequestDate;
    /// <summary>
    /// 发出连接请求的时间
    /// </summary>
    [Description("发出连接请求的时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ConnectRequestTime;
    /// <summary>
    /// 上次报告日期
    /// </summary>
    [Description("上次报告日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String LastReportDate;
    /// <summary>
    /// 上次报告时间
    /// </summary>
    [Description("上次报告时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String LastReportTime;
    /// <summary>
    /// 完成连接日期
    /// </summary>
    [Description("完成连接日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ConnectDate;
    /// <summary>
    /// 完成连接时间
    /// </summary>
    [Description("完成连接时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ConnectTime;
    /// <summary>
    /// 启动日期
    /// </summary>
    [Description("启动日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String StartDate;
    /// <summary>
    /// 启动时间
    /// </summary>
    [Description("启动时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String StartTime;
    /// <summary>
    /// 交易日
    /// </summary>
    [Description("交易日")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradingDay;
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 营业部编号
    /// </summary>
    [Description("营业部编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String BranchID;

  };

  /// <summary>
  /// 查询行情报盘机
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQryMDTraderOfferField
  {
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;
    /// <summary>
    /// 会员代码
    /// </summary>
    [Description("会员代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String ParticipantID;
    /// <summary>
    /// 交易所交易员代码
    /// </summary>
    [Description("交易所交易员代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String TraderID;

  };

  /// <summary>
  /// 查询客户通知
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQryNoticeField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;

  };

  /// <summary>
  /// 客户通知
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcNoticeField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 消息正文
    /// </summary>
    [Description("消息正文")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 501)]
    public String Content;
    /// <summary>
    /// 经纪公司通知内容序列号
    /// </summary>
    [Description("经纪公司通知内容序列号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public String SequenceLabel;

  };

  /// <summary>
  /// 用户权限
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcUserRightField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 用户代码
    /// </summary>
    [Description("用户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;
    /// <summary>
    /// 客户权限类型
    /// </summary>
    [Description("客户权限类型")]
    public CTPStockUserRightType UserRightType;
    /// <summary>
    /// 是否禁止
    /// </summary>
    [Description("是否禁止")]
    public bool IsForbidden;

  };

  /// <summary>
  /// 查询结算信息确认域
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQrySettlementInfoConfirmField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;

  };

  /// <summary>
  /// 装载结算信息
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcLoadSettlementInfoField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;

  };

  /// <summary>
  /// 经纪公司可提资金算法表
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcBrokerWithdrawAlgorithmField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 可提资金算法
    /// </summary>
    [Description("可提资金算法")]
    public CTPStockAlgorithmType WithdrawAlgorithm;
    /// <summary>
    /// 资金使用率
    /// </summary>
    [Description("资金使用率")]
    public double UsingRatio;
    /// <summary>
    /// 可提是否包含平仓盈利
    /// </summary>
    [Description("可提是否包含平仓盈利")]
    public CTPStockIncludeCloseProfitType IncludeCloseProfit;
    /// <summary>
    /// 本日无仓且无成交客户是否受可提比例限制
    /// </summary>
    [Description("本日无仓且无成交客户是否受可提比例限制")]
    public CTPStockAllWithoutTradeType AllWithoutTrade;
    /// <summary>
    /// 可用是否包含平仓盈利
    /// </summary>
    [Description("可用是否包含平仓盈利")]
    public CTPStockIncludeCloseProfitType AvailIncludeCloseProfit;
    /// <summary>
    /// 是否启用用户事件
    /// </summary>
    [Description("是否启用用户事件")]
    public bool IsBrokerUserEvent;

  };

  /// <summary>
  /// 资金账户口令变更域
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcTradingAccountPasswordUpdateV1Field
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 原来的口令
    /// </summary>
    [Description("原来的口令")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String OldPassword;
    /// <summary>
    /// 新的口令
    /// </summary>
    [Description("新的口令")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String NewPassword;

  };

  /// <summary>
  /// 资金账户口令变更域
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcTradingAccountPasswordUpdateField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者帐号
    /// </summary>
    [Description("投资者帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String AccountID;
    /// <summary>
    /// 原来的口令
    /// </summary>
    [Description("原来的口令")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String OldPassword;
    /// <summary>
    /// 新的口令
    /// </summary>
    [Description("新的口令")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String NewPassword;

  };

  /// <summary>
  /// 查询组合合约分腿
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQryCombinationLegField
  {
    /// <summary>
    /// 组合合约代码
    /// </summary>
    [Description("组合合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String CombInstrumentID;
    /// <summary>
    /// 单腿编号
    /// </summary>
    [Description("单腿编号")]
    public int LegID;
    /// <summary>
    /// 单腿合约代码
    /// </summary>
    [Description("单腿合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String LegInstrumentID;

  };

  /// <summary>
  /// 查询组合合约分腿
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQrySyncStatusField
  {
    /// <summary>
    /// 交易日
    /// </summary>
    [Description("交易日")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradingDay;

  };

  /// <summary>
  /// 组合交易合约的单腿
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcCombinationLegField
  {
    /// <summary>
    /// 组合合约代码
    /// </summary>
    [Description("组合合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String CombInstrumentID;
    /// <summary>
    /// 单腿编号
    /// </summary>
    [Description("单腿编号")]
    public int LegID;
    /// <summary>
    /// 单腿合约代码
    /// </summary>
    [Description("单腿合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String LegInstrumentID;
    /// <summary>
    /// 买卖方向
    /// </summary>
    [Description("买卖方向")]
    public CTPStockDirectionType Direction;
    /// <summary>
    /// 单腿乘数
    /// </summary>
    [Description("单腿乘数")]
    public int LegMultiple;
    /// <summary>
    /// 派生层数
    /// </summary>
    [Description("派生层数")]
    public int ImplyLevel;

  };

  /// <summary>
  /// 数据同步状态
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcSyncStatusField
  {
    /// <summary>
    /// 交易日
    /// </summary>
    [Description("交易日")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradingDay;
    /// <summary>
    /// 数据同步状态
    /// </summary>
    [Description("数据同步状态")]
    public CTPStockDataSyncStatusType DataSyncStatus;

  };

  /// <summary>
  /// 查询联系人
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQryLinkManField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;

  };

  /// <summary>
  /// 联系人
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcLinkManField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 联系人类型
    /// </summary>
    [Description("联系人类型")]
    public CTPStockPersonType PersonType;
    /// <summary>
    /// 证件类型
    /// </summary>
    [Description("证件类型")]
    public CTPStockIdCardType IdentifiedCardType;
    /// <summary>
    /// 证件号码
    /// </summary>
    [Description("证件号码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
    public String IdentifiedCardNo;
    /// <summary>
    /// 名称
    /// </summary>
    [Description("名称")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
    public String PersonName;
    /// <summary>
    /// 联系电话
    /// </summary>
    [Description("联系电话")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String Telephone;
    /// <summary>
    /// 通讯地址
    /// </summary>
    [Description("通讯地址")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
    public String Address;
    /// <summary>
    /// 邮政编码
    /// </summary>
    [Description("邮政编码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public String ZipCode;
    /// <summary>
    /// 优先级
    /// </summary>
    [Description("优先级")]
    public int Priority;

  };

  /// <summary>
  /// 查询经纪公司用户事件
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQryBrokerUserEventField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 用户代码
    /// </summary>
    [Description("用户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;
    /// <summary>
    /// 用户事件类型
    /// </summary>
    [Description("用户事件类型")]
    public CTPStockUserEventType UserEventType;

  };

  /// <summary>
  /// 查询经纪公司用户事件
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcBrokerUserEventField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 用户代码
    /// </summary>
    [Description("用户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;
    /// <summary>
    /// 用户事件类型
    /// </summary>
    [Description("用户事件类型")]
    public CTPStockUserEventType UserEventType;
    /// <summary>
    /// 用户事件序号
    /// </summary>
    [Description("用户事件序号")]
    public int EventSequenceNo;
    /// <summary>
    /// 事件发生日期
    /// </summary>
    [Description("事件发生日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String EventDate;
    /// <summary>
    /// 事件发生时间
    /// </summary>
    [Description("事件发生时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String EventTime;
    /// <summary>
    /// 用户事件信息
    /// </summary>
    [Description("用户事件信息")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1025)]
    public String UserEventInfo;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 合约代码
    /// </summary>
    [Description("合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String InstrumentID;

  };

  /// <summary>
  /// 查询签约银行请求
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQryContractBankField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 银行代码
    /// </summary>
    [Description("银行代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String BankID;
    /// <summary>
    /// 银行分中心代码
    /// </summary>
    [Description("银行分中心代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public String BankBrchID;

  };

  /// <summary>
  /// 查询签约银行响应
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcContractBankField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 银行代码
    /// </summary>
    [Description("银行代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String BankID;
    /// <summary>
    /// 银行分中心代码
    /// </summary>
    [Description("银行分中心代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public String BankBrchID;
    /// <summary>
    /// 银行名称
    /// </summary>
    [Description("银行名称")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
    public String BankName;

  };

  /// <summary>
  /// 投资者组合持仓明细
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcInvestorPositionCombineDetailField
  {
    /// <summary>
    /// 交易日
    /// </summary>
    [Description("交易日")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradingDay;
    /// <summary>
    /// 开仓日期
    /// </summary>
    [Description("开仓日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String OpenDate;
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;
    /// <summary>
    /// 结算编号
    /// </summary>
    [Description("结算编号")]
    public int SettlementID;
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 组合编号
    /// </summary>
    [Description("组合编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String ComTradeID;
    /// <summary>
    /// 撮合编号
    /// </summary>
    [Description("撮合编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String TradeID;
    /// <summary>
    /// 合约代码
    /// </summary>
    [Description("合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String InstrumentID;
    /// <summary>
    /// 投机套保标志
    /// </summary>
    [Description("投机套保标志")]
    public CTPStockHedgeFlagType HedgeFlag;
    /// <summary>
    /// 买卖
    /// </summary>
    [Description("买卖")]
    public CTPStockDirectionType Direction;
    /// <summary>
    /// 持仓量
    /// </summary>
    [Description("持仓量")]
    public int TotalAmt;
    /// <summary>
    /// 投资者保证金
    /// </summary>
    [Description("投资者保证金")]
    public double Margin;
    /// <summary>
    /// 交易所保证金
    /// </summary>
    [Description("交易所保证金")]
    public double ExchMargin;
    /// <summary>
    /// 保证金率
    /// </summary>
    [Description("保证金率")]
    public double MarginRateByMoney;
    /// <summary>
    /// 保证金率(按手数)
    /// </summary>
    [Description("保证金率(按手数)")]
    public double MarginRateByVolume;
    /// <summary>
    /// 单腿编号
    /// </summary>
    [Description("单腿编号")]
    public int LegID;
    /// <summary>
    /// 单腿乘数
    /// </summary>
    [Description("单腿乘数")]
    public int LegMultiple;
    /// <summary>
    /// 组合持仓合约编码
    /// </summary>
    [Description("组合持仓合约编码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String CombInstrumentID;

  };

  /// <summary>
  /// 预埋单
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcParkedOrderField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 合约代码
    /// </summary>
    [Description("合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String InstrumentID;
    /// <summary>
    /// 报单引用
    /// </summary>
    [Description("报单引用")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String OrderRef;
    /// <summary>
    /// 用户代码
    /// </summary>
    [Description("用户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;
    /// <summary>
    /// 报单价格条件
    /// </summary>
    [Description("报单价格条件")]
    public CTPStockOrderPriceType OrderPriceType;
    /// <summary>
    /// 买卖方向
    /// </summary>
    [Description("买卖方向")]
    public CTPStockDirectionType Direction;
    /// <summary>
    /// 组合开平标志
    /// </summary>
    [Description("组合开平标志")]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
    public byte[] CombOffsetFlag;
    /// <summary>
    /// 组合投机套保标志
    /// </summary>
    [Description("组合投机套保标志")]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
    public byte[] CombHedgeFlag;
    /// <summary>
    /// 价格
    /// </summary>
    [Description("价格")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String LimitPrice;
    /// <summary>
    /// 数量
    /// </summary>
    [Description("数量")]
    public int VolumeTotalOriginal;
    /// <summary>
    /// 有效期类型
    /// </summary>
    [Description("有效期类型")]
    public CTPStockTimeConditionType TimeCondition;
    /// <summary>
    /// GTD日期
    /// </summary>
    [Description("GTD日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String GTDDate;
    /// <summary>
    /// 成交量类型
    /// </summary>
    [Description("成交量类型")]
    public CTPStockVolumeConditionType VolumeCondition;
    /// <summary>
    /// 最小成交量
    /// </summary>
    [Description("最小成交量")]
    public int MinVolume;
    /// <summary>
    /// 触发条件
    /// </summary>
    [Description("触发条件")]
    public CTPStockContingentConditionType ContingentCondition;
    /// <summary>
    /// 止损价
    /// </summary>
    [Description("止损价")]
    public double StopPrice;
    /// <summary>
    /// 强平原因
    /// </summary>
    [Description("强平原因")]
    public CTPStockForceCloseReasonType ForceCloseReason;
    /// <summary>
    /// 自动挂起标志
    /// </summary>
    [Description("自动挂起标志")]
    public bool IsAutoSuspend;
    /// <summary>
    /// 业务单元
    /// </summary>
    [Description("业务单元")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String BusinessUnit;
    /// <summary>
    /// 请求编号
    /// </summary>
    [Description("请求编号")]
    public int RequestID;
    /// <summary>
    /// 用户强评标志
    /// </summary>
    [Description("用户强评标志")]
    public bool UserForceClose;
    /// <summary>
    /// 预埋报单编号
    /// </summary>
    [Description("预埋报单编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String ParkedOrderID;
    /// <summary>
    /// 用户类型
    /// </summary>
    [Description("用户类型")]
    public CTPStockUserType UserType;
    /// <summary>
    /// 预埋单状态
    /// </summary>
    [Description("预埋单状态")]
    public CTPStockParkedOrderStatusType Status;
    /// <summary>
    /// 错误代码
    /// </summary>
    [Description("错误代码")]
    public int ErrorID;
    /// <summary>
    /// 错误信息
    /// </summary>
    [Description("错误信息")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
    public String ErrorMsg;

  };

  /// <summary>
  /// 输入预埋单操作
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcParkedOrderActionField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 报单操作引用
    /// </summary>
    [Description("报单操作引用")]
    public int OrderActionRef;
    /// <summary>
    /// 报单引用
    /// </summary>
    [Description("报单引用")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String OrderRef;
    /// <summary>
    /// 请求编号
    /// </summary>
    [Description("请求编号")]
    public int RequestID;
    /// <summary>
    /// 前置编号
    /// </summary>
    [Description("前置编号")]
    public int FrontID;
    /// <summary>
    /// 会话编号
    /// </summary>
    [Description("会话编号")]
    public int SessionID;
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;
    /// <summary>
    /// 操作标志
    /// </summary>
    [Description("操作标志")]
    public CTPStockActionFlagType ActionFlag;
    /// <summary>
    /// 价格
    /// </summary>
    [Description("价格")]
    public double LimitPrice;
    /// <summary>
    /// 数量变化
    /// </summary>
    [Description("数量变化")]
    public int VolumeChange;
    /// <summary>
    /// 用户代码
    /// </summary>
    [Description("用户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;
    /// <summary>
    /// 合约代码
    /// </summary>
    [Description("合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String InstrumentID;
    /// <summary>
    /// 预埋撤单单编号
    /// </summary>
    [Description("预埋撤单单编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String ParkedOrderActionID;
    /// <summary>
    /// 用户类型
    /// </summary>
    [Description("用户类型")]
    public CTPStockUserType UserType;
    /// <summary>
    /// 预埋撤单状态
    /// </summary>
    [Description("预埋撤单状态")]
    public CTPStockParkedOrderStatusType Status;
    /// <summary>
    /// 错误代码
    /// </summary>
    [Description("错误代码")]
    public int ErrorID;
    /// <summary>
    /// 错误信息
    /// </summary>
    [Description("错误信息")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
    public String ErrorMsg;

  };

  /// <summary>
  /// 查询预埋单
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQryParkedOrderField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 合约代码
    /// </summary>
    [Description("合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String InstrumentID;
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;

  };

  /// <summary>
  /// 查询预埋撤单
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQryParkedOrderActionField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 合约代码
    /// </summary>
    [Description("合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String InstrumentID;
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;

  };

  /// <summary>
  /// 删除预埋单
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcRemoveParkedOrderField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 预埋报单编号
    /// </summary>
    [Description("预埋报单编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String ParkedOrderID;

  };

  /// <summary>
  /// 删除预埋撤单
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcRemoveParkedOrderActionField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 预埋撤单编号
    /// </summary>
    [Description("预埋撤单编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String ParkedOrderActionID;

  };

  /// <summary>
  /// 经纪公司可提资金算法表
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcInvestorWithdrawAlgorithmField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者范围
    /// </summary>
    [Description("投资者范围")]
    public CTPStockInvestorRangeType InvestorRange;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 可提资金比例
    /// </summary>
    [Description("可提资金比例")]
    public double UsingRatio;

  };

  /// <summary>
  /// 查询组合持仓明细
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQryInvestorPositionCombineDetailField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 组合持仓合约编码
    /// </summary>
    [Description("组合持仓合约编码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String CombInstrumentID;

  };

  /// <summary>
  /// 成交均价
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcMarketDataAveragePriceField
  {
    /// <summary>
    /// 当日均价
    /// </summary>
    [Description("当日均价")]
    public double AveragePrice;

  };

  /// <summary>
  /// 校验投资者密码
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcVerifyInvestorPasswordField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 密码
    /// </summary>
    [Description("密码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String Password;

  };

  /// <summary>
  /// 用户IP
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcUserIPField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 用户代码
    /// </summary>
    [Description("用户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;
    /// <summary>
    /// IP地址
    /// </summary>
    [Description("IP地址")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String IPAddress;
    /// <summary>
    /// IP地址掩码
    /// </summary>
    [Description("IP地址掩码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String IPMask;
    /// <summary>
    /// Mac地址
    /// </summary>
    [Description("Mac地址")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String MacAddress;

  };

  /// <summary>
  /// 用户事件通知信息
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcTradingNoticeInfoField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 发送时间
    /// </summary>
    [Description("发送时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String SendTime;
    /// <summary>
    /// 消息正文
    /// </summary>
    [Description("消息正文")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 501)]
    public String FieldContent;
    /// <summary>
    /// 序列系列号
    /// </summary>
    [Description("序列系列号")]
    public short SequenceSeries;
    /// <summary>
    /// 序列号
    /// </summary>
    [Description("序列号")]
    public int SequenceNo;

  };

  /// <summary>
  /// 用户事件通知
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcTradingNoticeField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者范围
    /// </summary>
    [Description("投资者范围")]
    public CTPStockInvestorRangeType InvestorRange;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 序列系列号
    /// </summary>
    [Description("序列系列号")]
    public short SequenceSeries;
    /// <summary>
    /// 用户代码
    /// </summary>
    [Description("用户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;
    /// <summary>
    /// 发送时间
    /// </summary>
    [Description("发送时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String SendTime;
    /// <summary>
    /// 序列号
    /// </summary>
    [Description("序列号")]
    public int SequenceNo;
    /// <summary>
    /// 消息正文
    /// </summary>
    [Description("消息正文")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 501)]
    public String FieldContent;

  };

  /// <summary>
  /// 查询交易事件通知
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQryTradingNoticeField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;

  };

  /// <summary>
  /// 查询错误报单
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQryErrOrderField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;

  };

  /// <summary>
  /// 错误报单
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcErrOrderField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 合约代码
    /// </summary>
    [Description("合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String InstrumentID;
    /// <summary>
    /// 报单引用
    /// </summary>
    [Description("报单引用")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String OrderRef;
    /// <summary>
    /// 用户代码
    /// </summary>
    [Description("用户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;
    /// <summary>
    /// 报单价格条件
    /// </summary>
    [Description("报单价格条件")]
    public CTPStockOrderPriceType OrderPriceType;
    /// <summary>
    /// 买卖方向
    /// </summary>
    [Description("买卖方向")]
    public CTPStockDirectionType Direction;
    /// <summary>
    /// 组合开平标志
    /// </summary>
    [Description("组合开平标志")]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
    public byte[] CombOffsetFlag;
    /// <summary>
    /// 组合投机套保标志
    /// </summary>
    [Description("组合投机套保标志")]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
    public byte[] CombHedgeFlag;
    /// <summary>
    /// 价格
    /// </summary>
    [Description("价格")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String LimitPrice;
    /// <summary>
    /// 数量
    /// </summary>
    [Description("数量")]
    public int VolumeTotalOriginal;
    /// <summary>
    /// 有效期类型
    /// </summary>
    [Description("有效期类型")]
    public CTPStockTimeConditionType TimeCondition;
    /// <summary>
    /// GTD日期
    /// </summary>
    [Description("GTD日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String GTDDate;
    /// <summary>
    /// 成交量类型
    /// </summary>
    [Description("成交量类型")]
    public CTPStockVolumeConditionType VolumeCondition;
    /// <summary>
    /// 最小成交量
    /// </summary>
    [Description("最小成交量")]
    public int MinVolume;
    /// <summary>
    /// 触发条件
    /// </summary>
    [Description("触发条件")]
    public CTPStockContingentConditionType ContingentCondition;
    /// <summary>
    /// 止损价
    /// </summary>
    [Description("止损价")]
    public double StopPrice;
    /// <summary>
    /// 强平原因
    /// </summary>
    [Description("强平原因")]
    public CTPStockForceCloseReasonType ForceCloseReason;
    /// <summary>
    /// 自动挂起标志
    /// </summary>
    [Description("自动挂起标志")]
    public bool IsAutoSuspend;
    /// <summary>
    /// 业务单元
    /// </summary>
    [Description("业务单元")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String BusinessUnit;
    /// <summary>
    /// 请求编号
    /// </summary>
    [Description("请求编号")]
    public int RequestID;
    /// <summary>
    /// 用户强评标志
    /// </summary>
    [Description("用户强评标志")]
    public bool UserForceClose;
    /// <summary>
    /// 错误代码
    /// </summary>
    [Description("错误代码")]
    public int ErrorID;
    /// <summary>
    /// 错误信息
    /// </summary>
    [Description("错误信息")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
    public String ErrorMsg;

  };

  /// <summary>
  /// 查询错误报单操作
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcErrorConditionalOrderField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 合约代码
    /// </summary>
    [Description("合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String InstrumentID;
    /// <summary>
    /// 报单引用
    /// </summary>
    [Description("报单引用")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String OrderRef;
    /// <summary>
    /// 用户代码
    /// </summary>
    [Description("用户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;
    /// <summary>
    /// 报单价格条件
    /// </summary>
    [Description("报单价格条件")]
    public CTPStockOrderPriceType OrderPriceType;
    /// <summary>
    /// 买卖方向
    /// </summary>
    [Description("买卖方向")]
    public CTPStockDirectionType Direction;
    /// <summary>
    /// 组合开平标志
    /// </summary>
    [Description("组合开平标志")]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
    public byte[] CombOffsetFlag;
    /// <summary>
    /// 组合投机套保标志
    /// </summary>
    [Description("组合投机套保标志")]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
    public byte[] CombHedgeFlag;
    /// <summary>
    /// 价格
    /// </summary>
    [Description("价格")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String LimitPrice;
    /// <summary>
    /// 数量
    /// </summary>
    [Description("数量")]
    public int VolumeTotalOriginal;
    /// <summary>
    /// 有效期类型
    /// </summary>
    [Description("有效期类型")]
    public CTPStockTimeConditionType TimeCondition;
    /// <summary>
    /// GTD日期
    /// </summary>
    [Description("GTD日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String GTDDate;
    /// <summary>
    /// 成交量类型
    /// </summary>
    [Description("成交量类型")]
    public CTPStockVolumeConditionType VolumeCondition;
    /// <summary>
    /// 最小成交量
    /// </summary>
    [Description("最小成交量")]
    public int MinVolume;
    /// <summary>
    /// 触发条件
    /// </summary>
    [Description("触发条件")]
    public CTPStockContingentConditionType ContingentCondition;
    /// <summary>
    /// 止损价
    /// </summary>
    [Description("止损价")]
    public double StopPrice;
    /// <summary>
    /// 强平原因
    /// </summary>
    [Description("强平原因")]
    public CTPStockForceCloseReasonType ForceCloseReason;
    /// <summary>
    /// 自动挂起标志
    /// </summary>
    [Description("自动挂起标志")]
    public bool IsAutoSuspend;
    /// <summary>
    /// 业务单元
    /// </summary>
    [Description("业务单元")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String BusinessUnit;
    /// <summary>
    /// 请求编号
    /// </summary>
    [Description("请求编号")]
    public int RequestID;
    /// <summary>
    /// 本地报单编号
    /// </summary>
    [Description("本地报单编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String OrderLocalID;
    /// <summary>
    /// 会员代码
    /// </summary>
    [Description("会员代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String ParticipantID;
    /// <summary>
    /// 客户代码
    /// </summary>
    [Description("客户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String ClientID;
    /// <summary>
    /// 合约在交易所的代码
    /// </summary>
    [Description("合约在交易所的代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String ExchangeInstID;
    /// <summary>
    /// 交易所交易员代码
    /// </summary>
    [Description("交易所交易员代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String TraderID;
    /// <summary>
    /// 安装编号
    /// </summary>
    [Description("安装编号")]
    public int InstallID;
    /// <summary>
    /// 报单提交状态
    /// </summary>
    [Description("报单提交状态")]
    public CTPStockOrderSubmitStatusType OrderSubmitStatus;
    /// <summary>
    /// 报单提示序号
    /// </summary>
    [Description("报单提示序号")]
    public int NotifySequence;
    /// <summary>
    /// 交易日
    /// </summary>
    [Description("交易日")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradingDay;
    /// <summary>
    /// 结算编号
    /// </summary>
    [Description("结算编号")]
    public int SettlementID;
    /// <summary>
    /// 报单编号
    /// </summary>
    [Description("报单编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String OrderSysID;
    /// <summary>
    /// 报单来源
    /// </summary>
    [Description("报单来源")]
    public CTPStockOrderSourceType OrderSource;
    /// <summary>
    /// 报单状态
    /// </summary>
    [Description("报单状态")]
    public CTPStockOrderStatusType OrderStatus;
    /// <summary>
    /// 报单类型
    /// </summary>
    [Description("报单类型")]
    public CTPStockOrderType OrderType;
    /// <summary>
    /// 今成交数量
    /// </summary>
    [Description("今成交数量")]
    public int VolumeTraded;
    /// <summary>
    /// 剩余数量
    /// </summary>
    [Description("剩余数量")]
    public int VolumeTotal;
    /// <summary>
    /// 报单日期
    /// </summary>
    [Description("报单日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String InsertDate;
    /// <summary>
    /// 委托时间
    /// </summary>
    [Description("委托时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String InsertTime;
    /// <summary>
    /// 激活时间
    /// </summary>
    [Description("激活时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ActiveTime;
    /// <summary>
    /// 挂起时间
    /// </summary>
    [Description("挂起时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String SuspendTime;
    /// <summary>
    /// 最后修改时间
    /// </summary>
    [Description("最后修改时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String UpdateTime;
    /// <summary>
    /// 撤销时间
    /// </summary>
    [Description("撤销时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String CancelTime;
    /// <summary>
    /// 最后修改交易所交易员代码
    /// </summary>
    [Description("最后修改交易所交易员代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String ActiveTraderID;
    /// <summary>
    /// 结算会员编号
    /// </summary>
    [Description("结算会员编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String ClearingPartID;
    /// <summary>
    /// 序号
    /// </summary>
    [Description("序号")]
    public int SequenceNo;
    /// <summary>
    /// 前置编号
    /// </summary>
    [Description("前置编号")]
    public int FrontID;
    /// <summary>
    /// 会话编号
    /// </summary>
    [Description("会话编号")]
    public int SessionID;
    /// <summary>
    /// 用户端产品信息
    /// </summary>
    [Description("用户端产品信息")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String UserProductInfo;
    /// <summary>
    /// 状态信息
    /// </summary>
    [Description("状态信息")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
    public String StatusMsg;
    /// <summary>
    /// 用户强评标志
    /// </summary>
    [Description("用户强评标志")]
    public bool UserForceClose;
    /// <summary>
    /// 操作用户代码
    /// </summary>
    [Description("操作用户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String ActiveUserID;
    /// <summary>
    /// 经纪公司报单编号
    /// </summary>
    [Description("经纪公司报单编号")]
    public int BrokerOrderSeq;
    /// <summary>
    /// 相关报单
    /// </summary>
    [Description("相关报单")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String RelativeOrderSysID;
    /// <summary>
    /// 营业部编号
    /// </summary>
    [Description("营业部编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String BranchID;
    /// <summary>
    /// 成交数量
    /// </summary>
    [Description("成交数量")]
    public double TradeAmount;
    /// <summary>
    /// 是否ETF
    /// </summary>
    [Description("是否ETF")]
    public bool IsETF;
    /// <summary>
    /// 资金帐号
    /// </summary>
    [Description("资金帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String AccountID;
    /// <summary>
    /// 错误代码
    /// </summary>
    [Description("错误代码")]
    public int ErrorID;
    /// <summary>
    /// 错误信息
    /// </summary>
    [Description("错误信息")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
    public String ErrorMsg;

  };

  /// <summary>
  /// 查询错误报单操作
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQryErrOrderActionField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;

  };

  /// <summary>
  /// 错误报单操作
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcErrOrderActionField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 报单操作引用
    /// </summary>
    [Description("报单操作引用")]
    public int OrderActionRef;
    /// <summary>
    /// 报单引用
    /// </summary>
    [Description("报单引用")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String OrderRef;
    /// <summary>
    /// 请求编号
    /// </summary>
    [Description("请求编号")]
    public int RequestID;
    /// <summary>
    /// 前置编号
    /// </summary>
    [Description("前置编号")]
    public int FrontID;
    /// <summary>
    /// 会话编号
    /// </summary>
    [Description("会话编号")]
    public int SessionID;
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;
    /// <summary>
    /// 操作标志
    /// </summary>
    [Description("操作标志")]
    public CTPStockActionFlagType ActionFlag;
    /// <summary>
    /// 价格
    /// </summary>
    [Description("价格")]
    public double LimitPrice;
    /// <summary>
    /// 数量变化
    /// </summary>
    [Description("数量变化")]
    public int VolumeChange;
    /// <summary>
    /// 操作日期
    /// </summary>
    [Description("操作日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ActionDate;
    /// <summary>
    /// 操作时间
    /// </summary>
    [Description("操作时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ActionTime;
    /// <summary>
    /// 交易所交易员代码
    /// </summary>
    [Description("交易所交易员代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String TraderID;
    /// <summary>
    /// 安装编号
    /// </summary>
    [Description("安装编号")]
    public int InstallID;
    /// <summary>
    /// 本地报单编号
    /// </summary>
    [Description("本地报单编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String OrderLocalID;
    /// <summary>
    /// 操作本地编号
    /// </summary>
    [Description("操作本地编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String ActionLocalID;
    /// <summary>
    /// 会员代码
    /// </summary>
    [Description("会员代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String ParticipantID;
    /// <summary>
    /// 客户代码
    /// </summary>
    [Description("客户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String ClientID;
    /// <summary>
    /// 业务单元
    /// </summary>
    [Description("业务单元")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String BusinessUnit;
    /// <summary>
    /// 报单操作状态
    /// </summary>
    [Description("报单操作状态")]
    public CTPStockOrderActionStatusType OrderActionStatus;
    /// <summary>
    /// 用户代码
    /// </summary>
    [Description("用户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;
    /// <summary>
    /// 营业部编号
    /// </summary>
    [Description("营业部编号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String BranchID;
    /// <summary>
    /// 状态信息
    /// </summary>
    [Description("状态信息")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
    public String StatusMsg;
    /// <summary>
    /// 合约代码
    /// </summary>
    [Description("合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String InstrumentID;
    /// <summary>
    /// 错误代码
    /// </summary>
    [Description("错误代码")]
    public int ErrorID;
    /// <summary>
    /// 错误信息
    /// </summary>
    [Description("错误信息")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
    public String ErrorMsg;

  };

  /// <summary>
  /// 查询交易所状态
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQryExchangeSequenceField
  {
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;

  };

  /// <summary>
  /// 交易所状态
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcExchangeSequenceField
  {
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;
    /// <summary>
    /// 序号
    /// </summary>
    [Description("序号")]
    public int SequenceNo;
    /// <summary>
    /// 合约交易状态
    /// </summary>
    [Description("合约交易状态")]
    public CTPStockInstrumentStatusType MarketStatus;

  };

  /// <summary>
  /// 根据价格查询最大报单数量
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQueryMaxOrderVolumeWithPriceField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 合约代码
    /// </summary>
    [Description("合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String InstrumentID;
    /// <summary>
    /// 买卖方向
    /// </summary>
    [Description("买卖方向")]
    public CTPStockDirectionType Direction;
    /// <summary>
    /// 开平标志
    /// </summary>
    [Description("开平标志")]
    public CTPStockOffsetFlagType OffsetFlag;
    /// <summary>
    /// 投机套保标志
    /// </summary>
    [Description("投机套保标志")]
    public CTPStockHedgeFlagType HedgeFlag;
    /// <summary>
    /// 最大允许报单数量
    /// </summary>
    [Description("最大允许报单数量")]
    public int MaxVolume;
    /// <summary>
    /// 报单价格
    /// </summary>
    [Description("报单价格")]
    public double Price;

  };

  /// <summary>
  /// 查询经纪公司交易参数
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQryBrokerTradingParamsField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;

  };

  /// <summary>
  /// 经纪公司交易参数
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcBrokerTradingParamsField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 保证金价格类型
    /// </summary>
    [Description("保证金价格类型")]
    public CTPStockMarginPriceType MarginPriceType;
    /// <summary>
    /// 盈亏算法
    /// </summary>
    [Description("盈亏算法")]
    public CTPStockAlgorithmType Algorithm;
    /// <summary>
    /// 可用是否包含平仓盈利
    /// </summary>
    [Description("可用是否包含平仓盈利")]
    public CTPStockIncludeCloseProfitType AvailIncludeCloseProfit;

  };

  /// <summary>
  /// 查询经纪公司交易算法
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQryBrokerTradingAlgosField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;
    /// <summary>
    /// 合约代码
    /// </summary>
    [Description("合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String InstrumentID;

  };

  /// <summary>
  /// 经纪公司交易算法
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcBrokerTradingAlgosField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;
    /// <summary>
    /// 合约代码
    /// </summary>
    [Description("合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String InstrumentID;
    /// <summary>
    /// 持仓处理算法编号
    /// </summary>
    [Description("持仓处理算法编号")]
    public CTPStockHandlePositionAlgoIDType HandlePositionAlgoID;
    /// <summary>
    /// 寻找保证金率算法编号
    /// </summary>
    [Description("寻找保证金率算法编号")]
    public CTPStockFindMarginRateAlgoIDType FindMarginRateAlgoID;
    /// <summary>
    /// 资金处理算法编号
    /// </summary>
    [Description("资金处理算法编号")]
    public CTPStockHandleTradingAccountAlgoIDType HandleTradingAccountAlgoID;

  };

  /// <summary>
  /// 查询经纪公司资金
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQueryBrokerDepositField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;

  };

  /// <summary>
  /// 经纪公司资金
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcBrokerDepositField
  {
    /// <summary>
    /// 交易日期
    /// </summary>
    [Description("交易日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradingDay;
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 会员代码
    /// </summary>
    [Description("会员代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String ParticipantID;
    /// <summary>
    /// 交易所代码
    /// </summary>
    [Description("交易所代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String ExchangeID;
    /// <summary>
    /// 上次结算准备金
    /// </summary>
    [Description("上次结算准备金")]
    public double PreBalance;
    /// <summary>
    /// 当前保证金总额
    /// </summary>
    [Description("当前保证金总额")]
    public double CurrMargin;
    /// <summary>
    /// 平仓盈亏
    /// </summary>
    [Description("平仓盈亏")]
    public double CloseProfit;
    /// <summary>
    /// 期货结算准备金
    /// </summary>
    [Description("期货结算准备金")]
    public double Balance;
    /// <summary>
    /// 入金金额
    /// </summary>
    [Description("入金金额")]
    public double Deposit;
    /// <summary>
    /// 出金金额
    /// </summary>
    [Description("出金金额")]
    public double Withdraw;
    /// <summary>
    /// 可提资金
    /// </summary>
    [Description("可提资金")]
    public double Available;
    /// <summary>
    /// 基本准备金
    /// </summary>
    [Description("基本准备金")]
    public double Reserve;
    /// <summary>
    /// 冻结的保证金
    /// </summary>
    [Description("冻结的保证金")]
    public double FrozenMargin;

  };

  /// <summary>
  /// 查询保证金监管系统经纪公司密钥
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQryCFMMCBrokerKeyField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;

  };

  /// <summary>
  /// 保证金监管系统经纪公司密钥
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcCFMMCBrokerKeyField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 经纪公司统一编码
    /// </summary>
    [Description("经纪公司统一编码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String ParticipantID;
    /// <summary>
    /// 密钥生成日期
    /// </summary>
    [Description("密钥生成日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String CreateDate;
    /// <summary>
    /// 密钥生成时间
    /// </summary>
    [Description("密钥生成时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String CreateTime;
    /// <summary>
    /// 密钥编号
    /// </summary>
    [Description("密钥编号")]
    public int KeyID;
    /// <summary>
    /// 动态密钥
    /// </summary>
    [Description("动态密钥")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String CurrentKey;
    /// <summary>
    /// 动态密钥类型
    /// </summary>
    [Description("动态密钥类型")]
    public CTPStockCFMMCKeyKindType KeyKind;

  };

  /// <summary>
  /// 保证金监管系统经纪公司资金账户密钥
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcCFMMCTradingAccountKeyField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 经纪公司统一编码
    /// </summary>
    [Description("经纪公司统一编码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String ParticipantID;
    /// <summary>
    /// 投资者帐号
    /// </summary>
    [Description("投资者帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String AccountID;
    /// <summary>
    /// 密钥编号
    /// </summary>
    [Description("密钥编号")]
    public int KeyID;
    /// <summary>
    /// 动态密钥
    /// </summary>
    [Description("动态密钥")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String CurrentKey;

  };

  /// <summary>
  /// 请求查询保证金监管系统经纪公司资金账户密钥
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQryCFMMCTradingAccountKeyField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;

  };

  /// <summary>
  /// 用户动态令牌参数
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcBrokerUserOTPParamField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 用户代码
    /// </summary>
    [Description("用户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;
    /// <summary>
    /// 动态令牌提供商
    /// </summary>
    [Description("动态令牌提供商")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
    public String OTPVendorsID;
    /// <summary>
    /// 动态令牌序列号
    /// </summary>
    [Description("动态令牌序列号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
    public String SerialNumber;
    /// <summary>
    /// 令牌密钥
    /// </summary>
    [Description("令牌密钥")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String AuthKey;
    /// <summary>
    /// 漂移值
    /// </summary>
    [Description("漂移值")]
    public int LastDrift;
    /// <summary>
    /// 成功值
    /// </summary>
    [Description("成功值")]
    public int LastSuccess;
    /// <summary>
    /// 动态令牌类型
    /// </summary>
    [Description("动态令牌类型")]
    public CTPStockOTPType OTPType;

  };

  /// <summary>
  /// 手工同步用户动态令牌
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcManualSyncBrokerUserOTPField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 用户代码
    /// </summary>
    [Description("用户代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;
    /// <summary>
    /// 动态令牌类型
    /// </summary>
    [Description("动态令牌类型")]
    public CTPStockOTPType OTPType;
    /// <summary>
    /// 第一个动态密码
    /// </summary>
    [Description("第一个动态密码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String FirstOTP;
    /// <summary>
    /// 第二个动态密码
    /// </summary>
    [Description("第二个动态密码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String SecondOTP;

  };

  /// <summary>
  /// 转帐开户请求
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcReqOpenAccountField
  {
    /// <summary>
    /// 业务功能码
    /// </summary>
    [Description("业务功能码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public String TradeCode;
    /// <summary>
    /// 银行代码
    /// </summary>
    [Description("银行代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String BankID;
    /// <summary>
    /// 银行分支机构代码
    /// </summary>
    [Description("银行分支机构代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public String BankBranchID;
    /// <summary>
    /// 期商代码
    /// </summary>
    [Description("期商代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 期商分支机构代码
    /// </summary>
    [Description("期商分支机构代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String BrokerBranchID;
    /// <summary>
    /// 交易日期
    /// </summary>
    [Description("交易日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeDate;
    /// <summary>
    /// 交易时间
    /// </summary>
    [Description("交易时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeTime;
    /// <summary>
    /// 银行流水号
    /// </summary>
    [Description("银行流水号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String BankSerial;
    /// <summary>
    /// 交易系统日期 
    /// </summary>
    [Description("交易系统日期 ")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradingDay;
    /// <summary>
    /// 银期平台消息流水号
    /// </summary>
    [Description("银期平台消息流水号")]
    public int PlateSerial;
    /// <summary>
    /// 最后分片标志
    /// </summary>
    [Description("最后分片标志")]
    public CTPStockLastFragmentType LastFragment;
    /// <summary>
    /// 会话号
    /// </summary>
    [Description("会话号")]
    public int SessionID;
    /// <summary>
    /// 客户姓名
    /// </summary>
    [Description("客户姓名")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
    public String CustomerName;
    /// <summary>
    /// 证件类型
    /// </summary>
    [Description("证件类型")]
    public CTPStockIdCardType IdCardType;
    /// <summary>
    /// 证件号码
    /// </summary>
    [Description("证件号码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
    public String IdentifiedCardNo;
    /// <summary>
    /// 性别
    /// </summary>
    [Description("性别")]
    public CTPStockGenderType Gender;
    /// <summary>
    /// 国家代码
    /// </summary>
    [Description("国家代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String CountryCode;
    /// <summary>
    /// 客户类型
    /// </summary>
    [Description("客户类型")]
    public CTPStockCustType CustType;
    /// <summary>
    /// 地址
    /// </summary>
    [Description("地址")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
    public String Address;
    /// <summary>
    /// 邮编
    /// </summary>
    [Description("邮编")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public String ZipCode;
    /// <summary>
    /// 电话号码
    /// </summary>
    [Description("电话号码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String Telephone;
    /// <summary>
    /// 手机
    /// </summary>
    [Description("手机")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String MobilePhone;
    /// <summary>
    /// 传真
    /// </summary>
    [Description("传真")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String Fax;
    /// <summary>
    /// 电子邮件
    /// </summary>
    [Description("电子邮件")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String EMail;
    /// <summary>
    /// 资金账户状态
    /// </summary>
    [Description("资金账户状态")]
    public CTPStockMoneyAccountStatusType MoneyAccountStatus;
    /// <summary>
    /// 银行帐号
    /// </summary>
    [Description("银行帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String BankAccount;
    /// <summary>
    /// 银行密码
    /// </summary>
    [Description("银行密码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String BankPassWord;
    /// <summary>
    /// 投资者帐号
    /// </summary>
    [Description("投资者帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String AccountID;
    /// <summary>
    /// 期货密码
    /// </summary>
    [Description("期货密码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String Password;
    /// <summary>
    /// 安装编号
    /// </summary>
    [Description("安装编号")]
    public int InstallID;
    /// <summary>
    /// 验证客户证件号码标志
    /// </summary>
    [Description("验证客户证件号码标志")]
    public CTPStockYesNoIndicatorType VerifyCertNoFlag;
    /// <summary>
    /// 币种代码
    /// </summary>
    [Description("币种代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String CurrencyID;
    /// <summary>
    /// 汇钞标志
    /// </summary>
    [Description("汇钞标志")]
    public CTPStockCashExchangeCodeType CashExchangeCode;
    /// <summary>
    /// 摘要
    /// </summary>
    [Description("摘要")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
    public String Digest;
    /// <summary>
    /// 银行帐号类型
    /// </summary>
    [Description("银行帐号类型")]
    public CTPStockBankAccType BankAccType;
    /// <summary>
    /// 渠道标志
    /// </summary>
    [Description("渠道标志")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public String DeviceID;
    /// <summary>
    /// 期货单位帐号类型
    /// </summary>
    [Description("期货单位帐号类型")]
    public CTPStockBankAccType BankSecuAccType;
    /// <summary>
    /// 期货公司银行编码
    /// </summary>
    [Description("期货公司银行编码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
    public String BrokerIDByBank;
    /// <summary>
    /// 期货单位帐号
    /// </summary>
    [Description("期货单位帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String BankSecuAcc;
    /// <summary>
    /// 银行密码标志
    /// </summary>
    [Description("银行密码标志")]
    public CTPStockPwdFlagType BankPwdFlag;
    /// <summary>
    /// 期货资金密码核对标志
    /// </summary>
    [Description("期货资金密码核对标志")]
    public CTPStockPwdFlagType SecuPwdFlag;
    /// <summary>
    /// 交易柜员
    /// </summary>
    [Description("交易柜员")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
    public String OperNo;
    /// <summary>
    /// 交易ID
    /// </summary>
    [Description("交易ID")]
    public int TID;

  };

  /// <summary>
  /// 转帐销户请求
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcReqCancelAccountField
  {
    /// <summary>
    /// 业务功能码
    /// </summary>
    [Description("业务功能码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public String TradeCode;
    /// <summary>
    /// 银行代码
    /// </summary>
    [Description("银行代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String BankID;
    /// <summary>
    /// 银行分支机构代码
    /// </summary>
    [Description("银行分支机构代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public String BankBranchID;
    /// <summary>
    /// 期商代码
    /// </summary>
    [Description("期商代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 期商分支机构代码
    /// </summary>
    [Description("期商分支机构代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String BrokerBranchID;
    /// <summary>
    /// 交易日期
    /// </summary>
    [Description("交易日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeDate;
    /// <summary>
    /// 交易时间
    /// </summary>
    [Description("交易时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeTime;
    /// <summary>
    /// 银行流水号
    /// </summary>
    [Description("银行流水号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String BankSerial;
    /// <summary>
    /// 交易系统日期 
    /// </summary>
    [Description("交易系统日期 ")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradingDay;
    /// <summary>
    /// 银期平台消息流水号
    /// </summary>
    [Description("银期平台消息流水号")]
    public int PlateSerial;
    /// <summary>
    /// 最后分片标志
    /// </summary>
    [Description("最后分片标志")]
    public CTPStockLastFragmentType LastFragment;
    /// <summary>
    /// 会话号
    /// </summary>
    [Description("会话号")]
    public int SessionID;
    /// <summary>
    /// 客户姓名
    /// </summary>
    [Description("客户姓名")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
    public String CustomerName;
    /// <summary>
    /// 证件类型
    /// </summary>
    [Description("证件类型")]
    public CTPStockIdCardType IdCardType;
    /// <summary>
    /// 证件号码
    /// </summary>
    [Description("证件号码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
    public String IdentifiedCardNo;
    /// <summary>
    /// 性别
    /// </summary>
    [Description("性别")]
    public CTPStockGenderType Gender;
    /// <summary>
    /// 国家代码
    /// </summary>
    [Description("国家代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String CountryCode;
    /// <summary>
    /// 客户类型
    /// </summary>
    [Description("客户类型")]
    public CTPStockCustType CustType;
    /// <summary>
    /// 地址
    /// </summary>
    [Description("地址")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
    public String Address;
    /// <summary>
    /// 邮编
    /// </summary>
    [Description("邮编")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public String ZipCode;
    /// <summary>
    /// 电话号码
    /// </summary>
    [Description("电话号码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String Telephone;
    /// <summary>
    /// 手机
    /// </summary>
    [Description("手机")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String MobilePhone;
    /// <summary>
    /// 传真
    /// </summary>
    [Description("传真")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String Fax;
    /// <summary>
    /// 电子邮件
    /// </summary>
    [Description("电子邮件")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String EMail;
    /// <summary>
    /// 资金账户状态
    /// </summary>
    [Description("资金账户状态")]
    public CTPStockMoneyAccountStatusType MoneyAccountStatus;
    /// <summary>
    /// 银行帐号
    /// </summary>
    [Description("银行帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String BankAccount;
    /// <summary>
    /// 银行密码
    /// </summary>
    [Description("银行密码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String BankPassWord;
    /// <summary>
    /// 投资者帐号
    /// </summary>
    [Description("投资者帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String AccountID;
    /// <summary>
    /// 期货密码
    /// </summary>
    [Description("期货密码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String Password;
    /// <summary>
    /// 安装编号
    /// </summary>
    [Description("安装编号")]
    public int InstallID;
    /// <summary>
    /// 验证客户证件号码标志
    /// </summary>
    [Description("验证客户证件号码标志")]
    public CTPStockYesNoIndicatorType VerifyCertNoFlag;
    /// <summary>
    /// 币种代码
    /// </summary>
    [Description("币种代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String CurrencyID;
    /// <summary>
    /// 汇钞标志
    /// </summary>
    [Description("汇钞标志")]
    public CTPStockCashExchangeCodeType CashExchangeCode;
    /// <summary>
    /// 摘要
    /// </summary>
    [Description("摘要")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
    public String Digest;
    /// <summary>
    /// 银行帐号类型
    /// </summary>
    [Description("银行帐号类型")]
    public CTPStockBankAccType BankAccType;
    /// <summary>
    /// 渠道标志
    /// </summary>
    [Description("渠道标志")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public String DeviceID;
    /// <summary>
    /// 期货单位帐号类型
    /// </summary>
    [Description("期货单位帐号类型")]
    public CTPStockBankAccType BankSecuAccType;
    /// <summary>
    /// 期货公司银行编码
    /// </summary>
    [Description("期货公司银行编码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
    public String BrokerIDByBank;
    /// <summary>
    /// 期货单位帐号
    /// </summary>
    [Description("期货单位帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String BankSecuAcc;
    /// <summary>
    /// 银行密码标志
    /// </summary>
    [Description("银行密码标志")]
    public CTPStockPwdFlagType BankPwdFlag;
    /// <summary>
    /// 期货资金密码核对标志
    /// </summary>
    [Description("期货资金密码核对标志")]
    public CTPStockPwdFlagType SecuPwdFlag;
    /// <summary>
    /// 交易柜员
    /// </summary>
    [Description("交易柜员")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
    public String OperNo;
    /// <summary>
    /// 交易ID
    /// </summary>
    [Description("交易ID")]
    public int TID;

  };

  /// <summary>
  /// 变更银行账户请求
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcReqChangeAccountField
  {
    /// <summary>
    /// 业务功能码
    /// </summary>
    [Description("业务功能码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public String TradeCode;
    /// <summary>
    /// 银行代码
    /// </summary>
    [Description("银行代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String BankID;
    /// <summary>
    /// 银行分支机构代码
    /// </summary>
    [Description("银行分支机构代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public String BankBranchID;
    /// <summary>
    /// 期商代码
    /// </summary>
    [Description("期商代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 期商分支机构代码
    /// </summary>
    [Description("期商分支机构代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String BrokerBranchID;
    /// <summary>
    /// 交易日期
    /// </summary>
    [Description("交易日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeDate;
    /// <summary>
    /// 交易时间
    /// </summary>
    [Description("交易时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeTime;
    /// <summary>
    /// 银行流水号
    /// </summary>
    [Description("银行流水号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String BankSerial;
    /// <summary>
    /// 交易系统日期 
    /// </summary>
    [Description("交易系统日期 ")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradingDay;
    /// <summary>
    /// 银期平台消息流水号
    /// </summary>
    [Description("银期平台消息流水号")]
    public int PlateSerial;
    /// <summary>
    /// 最后分片标志
    /// </summary>
    [Description("最后分片标志")]
    public CTPStockLastFragmentType LastFragment;
    /// <summary>
    /// 会话号
    /// </summary>
    [Description("会话号")]
    public int SessionID;
    /// <summary>
    /// 客户姓名
    /// </summary>
    [Description("客户姓名")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
    public String CustomerName;
    /// <summary>
    /// 证件类型
    /// </summary>
    [Description("证件类型")]
    public CTPStockIdCardType IdCardType;
    /// <summary>
    /// 证件号码
    /// </summary>
    [Description("证件号码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
    public String IdentifiedCardNo;
    /// <summary>
    /// 性别
    /// </summary>
    [Description("性别")]
    public CTPStockGenderType Gender;
    /// <summary>
    /// 国家代码
    /// </summary>
    [Description("国家代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String CountryCode;
    /// <summary>
    /// 客户类型
    /// </summary>
    [Description("客户类型")]
    public CTPStockCustType CustType;
    /// <summary>
    /// 地址
    /// </summary>
    [Description("地址")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
    public String Address;
    /// <summary>
    /// 邮编
    /// </summary>
    [Description("邮编")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public String ZipCode;
    /// <summary>
    /// 电话号码
    /// </summary>
    [Description("电话号码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String Telephone;
    /// <summary>
    /// 手机
    /// </summary>
    [Description("手机")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
    public String MobilePhone;
    /// <summary>
    /// 传真
    /// </summary>
    [Description("传真")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String Fax;
    /// <summary>
    /// 电子邮件
    /// </summary>
    [Description("电子邮件")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String EMail;
    /// <summary>
    /// 资金账户状态
    /// </summary>
    [Description("资金账户状态")]
    public CTPStockMoneyAccountStatusType MoneyAccountStatus;
    /// <summary>
    /// 银行帐号
    /// </summary>
    [Description("银行帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String BankAccount;
    /// <summary>
    /// 银行密码
    /// </summary>
    [Description("银行密码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String BankPassWord;
    /// <summary>
    /// 新银行帐号
    /// </summary>
    [Description("新银行帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String NewBankAccount;
    /// <summary>
    /// 新银行密码
    /// </summary>
    [Description("新银行密码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String NewBankPassWord;
    /// <summary>
    /// 投资者帐号
    /// </summary>
    [Description("投资者帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String AccountID;
    /// <summary>
    /// 期货密码
    /// </summary>
    [Description("期货密码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String Password;
    /// <summary>
    /// 银行帐号类型
    /// </summary>
    [Description("银行帐号类型")]
    public CTPStockBankAccType BankAccType;
    /// <summary>
    /// 安装编号
    /// </summary>
    [Description("安装编号")]
    public int InstallID;
    /// <summary>
    /// 验证客户证件号码标志
    /// </summary>
    [Description("验证客户证件号码标志")]
    public CTPStockYesNoIndicatorType VerifyCertNoFlag;
    /// <summary>
    /// 币种代码
    /// </summary>
    [Description("币种代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String CurrencyID;
    /// <summary>
    /// 期货公司银行编码
    /// </summary>
    [Description("期货公司银行编码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
    public String BrokerIDByBank;
    /// <summary>
    /// 银行密码标志
    /// </summary>
    [Description("银行密码标志")]
    public CTPStockPwdFlagType BankPwdFlag;
    /// <summary>
    /// 期货资金密码核对标志
    /// </summary>
    [Description("期货资金密码核对标志")]
    public CTPStockPwdFlagType SecuPwdFlag;
    /// <summary>
    /// 交易ID
    /// </summary>
    [Description("交易ID")]
    public int TID;
    /// <summary>
    /// 摘要
    /// </summary>
    [Description("摘要")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
    public String Digest;

  };

  /// <summary>
  /// 转账请求
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcReqTransferField
  {
    /// <summary>
    /// 业务功能码
    /// </summary>
    [Description("业务功能码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public String TradeCode;
    /// <summary>
    /// 银行代码
    /// </summary>
    [Description("银行代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String BankID;
    /// <summary>
    /// 银行分支机构代码
    /// </summary>
    [Description("银行分支机构代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public String BankBranchID;
    /// <summary>
    /// 期商代码
    /// </summary>
    [Description("期商代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 期商分支机构代码
    /// </summary>
    [Description("期商分支机构代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String BrokerBranchID;
    /// <summary>
    /// 交易日期
    /// </summary>
    [Description("交易日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeDate;
    /// <summary>
    /// 交易时间
    /// </summary>
    [Description("交易时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeTime;
    /// <summary>
    /// 银行流水号
    /// </summary>
    [Description("银行流水号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String BankSerial;
    /// <summary>
    /// 交易系统日期 
    /// </summary>
    [Description("交易系统日期 ")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradingDay;
    /// <summary>
    /// 银期平台消息流水号
    /// </summary>
    [Description("银期平台消息流水号")]
    public int PlateSerial;
    /// <summary>
    /// 最后分片标志
    /// </summary>
    [Description("最后分片标志")]
    public CTPStockLastFragmentType LastFragment;
    /// <summary>
    /// 会话号
    /// </summary>
    [Description("会话号")]
    public int SessionID;
    /// <summary>
    /// 客户姓名
    /// </summary>
    [Description("客户姓名")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
    public String CustomerName;
    /// <summary>
    /// 证件类型
    /// </summary>
    [Description("证件类型")]
    public CTPStockIdCardType IdCardType;
    /// <summary>
    /// 证件号码
    /// </summary>
    [Description("证件号码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
    public String IdentifiedCardNo;
    /// <summary>
    /// 客户类型
    /// </summary>
    [Description("客户类型")]
    public CTPStockCustType CustType;
    /// <summary>
    /// 银行帐号
    /// </summary>
    [Description("银行帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String BankAccount;
    /// <summary>
    /// 银行密码
    /// </summary>
    [Description("银行密码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String BankPassWord;
    /// <summary>
    /// 投资者帐号
    /// </summary>
    [Description("投资者帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String AccountID;
    /// <summary>
    /// 期货密码
    /// </summary>
    [Description("期货密码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String Password;
    /// <summary>
    /// 安装编号
    /// </summary>
    [Description("安装编号")]
    public int InstallID;
    /// <summary>
    /// 期货公司流水号
    /// </summary>
    [Description("期货公司流水号")]
    public int FutureSerial;
    /// <summary>
    /// 用户标识
    /// </summary>
    [Description("用户标识")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;
    /// <summary>
    /// 验证客户证件号码标志
    /// </summary>
    [Description("验证客户证件号码标志")]
    public CTPStockYesNoIndicatorType VerifyCertNoFlag;
    /// <summary>
    /// 币种代码
    /// </summary>
    [Description("币种代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String CurrencyID;
    /// <summary>
    /// 转帐金额
    /// </summary>
    [Description("转帐金额")]
    public double TradeAmount;
    /// <summary>
    /// 期货可取金额
    /// </summary>
    [Description("期货可取金额")]
    public double FutureFetchAmount;
    /// <summary>
    /// 费用支付标志
    /// </summary>
    [Description("费用支付标志")]
    public CTPStockFeePayFlagType FeePayFlag;
    /// <summary>
    /// 应收客户费用
    /// </summary>
    [Description("应收客户费用")]
    public double CustFee;
    /// <summary>
    /// 应收期货公司费用
    /// </summary>
    [Description("应收期货公司费用")]
    public double BrokerFee;
    /// <summary>
    /// 发送方给接收方的消息
    /// </summary>
    [Description("发送方给接收方的消息")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
    public String Message;
    /// <summary>
    /// 摘要
    /// </summary>
    [Description("摘要")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
    public String Digest;
    /// <summary>
    /// 银行帐号类型
    /// </summary>
    [Description("银行帐号类型")]
    public CTPStockBankAccType BankAccType;
    /// <summary>
    /// 渠道标志
    /// </summary>
    [Description("渠道标志")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public String DeviceID;
    /// <summary>
    /// 期货单位帐号类型
    /// </summary>
    [Description("期货单位帐号类型")]
    public CTPStockBankAccType BankSecuAccType;
    /// <summary>
    /// 期货公司银行编码
    /// </summary>
    [Description("期货公司银行编码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
    public String BrokerIDByBank;
    /// <summary>
    /// 期货单位帐号
    /// </summary>
    [Description("期货单位帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String BankSecuAcc;
    /// <summary>
    /// 银行密码标志
    /// </summary>
    [Description("银行密码标志")]
    public CTPStockPwdFlagType BankPwdFlag;
    /// <summary>
    /// 期货资金密码核对标志
    /// </summary>
    [Description("期货资金密码核对标志")]
    public CTPStockPwdFlagType SecuPwdFlag;
    /// <summary>
    /// 交易柜员
    /// </summary>
    [Description("交易柜员")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
    public String OperNo;
    /// <summary>
    /// 请求编号
    /// </summary>
    [Description("请求编号")]
    public int RequestID;
    /// <summary>
    /// 交易ID
    /// </summary>
    [Description("交易ID")]
    public int TID;
    /// <summary>
    /// 转账交易状态
    /// </summary>
    [Description("转账交易状态")]
    public CTPStockTransferStatusType TransferStatus;

  };

  /// <summary>
  /// 银行发起银行资金转期货响应
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcRspTransferField
  {
    /// <summary>
    /// 业务功能码
    /// </summary>
    [Description("业务功能码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public String TradeCode;
    /// <summary>
    /// 银行代码
    /// </summary>
    [Description("银行代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String BankID;
    /// <summary>
    /// 银行分支机构代码
    /// </summary>
    [Description("银行分支机构代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public String BankBranchID;
    /// <summary>
    /// 期商代码
    /// </summary>
    [Description("期商代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 期商分支机构代码
    /// </summary>
    [Description("期商分支机构代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String BrokerBranchID;
    /// <summary>
    /// 交易日期
    /// </summary>
    [Description("交易日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeDate;
    /// <summary>
    /// 交易时间
    /// </summary>
    [Description("交易时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeTime;
    /// <summary>
    /// 银行流水号
    /// </summary>
    [Description("银行流水号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String BankSerial;
    /// <summary>
    /// 交易系统日期 
    /// </summary>
    [Description("交易系统日期 ")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradingDay;
    /// <summary>
    /// 银期平台消息流水号
    /// </summary>
    [Description("银期平台消息流水号")]
    public int PlateSerial;
    /// <summary>
    /// 最后分片标志
    /// </summary>
    [Description("最后分片标志")]
    public CTPStockLastFragmentType LastFragment;
    /// <summary>
    /// 会话号
    /// </summary>
    [Description("会话号")]
    public int SessionID;
    /// <summary>
    /// 客户姓名
    /// </summary>
    [Description("客户姓名")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
    public String CustomerName;
    /// <summary>
    /// 证件类型
    /// </summary>
    [Description("证件类型")]
    public CTPStockIdCardType IdCardType;
    /// <summary>
    /// 证件号码
    /// </summary>
    [Description("证件号码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
    public String IdentifiedCardNo;
    /// <summary>
    /// 客户类型
    /// </summary>
    [Description("客户类型")]
    public CTPStockCustType CustType;
    /// <summary>
    /// 银行帐号
    /// </summary>
    [Description("银行帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String BankAccount;
    /// <summary>
    /// 银行密码
    /// </summary>
    [Description("银行密码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String BankPassWord;
    /// <summary>
    /// 投资者帐号
    /// </summary>
    [Description("投资者帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String AccountID;
    /// <summary>
    /// 期货密码
    /// </summary>
    [Description("期货密码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String Password;
    /// <summary>
    /// 安装编号
    /// </summary>
    [Description("安装编号")]
    public int InstallID;
    /// <summary>
    /// 期货公司流水号
    /// </summary>
    [Description("期货公司流水号")]
    public int FutureSerial;
    /// <summary>
    /// 用户标识
    /// </summary>
    [Description("用户标识")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;
    /// <summary>
    /// 验证客户证件号码标志
    /// </summary>
    [Description("验证客户证件号码标志")]
    public CTPStockYesNoIndicatorType VerifyCertNoFlag;
    /// <summary>
    /// 币种代码
    /// </summary>
    [Description("币种代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String CurrencyID;
    /// <summary>
    /// 转帐金额
    /// </summary>
    [Description("转帐金额")]
    public double TradeAmount;
    /// <summary>
    /// 期货可取金额
    /// </summary>
    [Description("期货可取金额")]
    public double FutureFetchAmount;
    /// <summary>
    /// 费用支付标志
    /// </summary>
    [Description("费用支付标志")]
    public CTPStockFeePayFlagType FeePayFlag;
    /// <summary>
    /// 应收客户费用
    /// </summary>
    [Description("应收客户费用")]
    public double CustFee;
    /// <summary>
    /// 应收期货公司费用
    /// </summary>
    [Description("应收期货公司费用")]
    public double BrokerFee;
    /// <summary>
    /// 发送方给接收方的消息
    /// </summary>
    [Description("发送方给接收方的消息")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
    public String Message;
    /// <summary>
    /// 摘要
    /// </summary>
    [Description("摘要")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
    public String Digest;
    /// <summary>
    /// 银行帐号类型
    /// </summary>
    [Description("银行帐号类型")]
    public CTPStockBankAccType BankAccType;
    /// <summary>
    /// 渠道标志
    /// </summary>
    [Description("渠道标志")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public String DeviceID;
    /// <summary>
    /// 期货单位帐号类型
    /// </summary>
    [Description("期货单位帐号类型")]
    public CTPStockBankAccType BankSecuAccType;
    /// <summary>
    /// 期货公司银行编码
    /// </summary>
    [Description("期货公司银行编码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
    public String BrokerIDByBank;
    /// <summary>
    /// 期货单位帐号
    /// </summary>
    [Description("期货单位帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String BankSecuAcc;
    /// <summary>
    /// 银行密码标志
    /// </summary>
    [Description("银行密码标志")]
    public CTPStockPwdFlagType BankPwdFlag;
    /// <summary>
    /// 期货资金密码核对标志
    /// </summary>
    [Description("期货资金密码核对标志")]
    public CTPStockPwdFlagType SecuPwdFlag;
    /// <summary>
    /// 交易柜员
    /// </summary>
    [Description("交易柜员")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
    public String OperNo;
    /// <summary>
    /// 请求编号
    /// </summary>
    [Description("请求编号")]
    public int RequestID;
    /// <summary>
    /// 交易ID
    /// </summary>
    [Description("交易ID")]
    public int TID;
    /// <summary>
    /// 转账交易状态
    /// </summary>
    [Description("转账交易状态")]
    public CTPStockTransferStatusType TransferStatus;
    /// <summary>
    /// 错误代码
    /// </summary>
    [Description("错误代码")]
    public int ErrorID;
    /// <summary>
    /// 错误信息
    /// </summary>
    [Description("错误信息")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
    public String ErrorMsg;

  };

  /// <summary>
  /// 冲正请求
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcReqRepealField
  {
    /// <summary>
    /// 冲正时间间隔
    /// </summary>
    [Description("冲正时间间隔")]
    public int RepealTimeInterval;
    /// <summary>
    /// 已经冲正次数
    /// </summary>
    [Description("已经冲正次数")]
    public int RepealedTimes;
    /// <summary>
    /// 银行冲正标志
    /// </summary>
    [Description("银行冲正标志")]
    public CTPStockBankRepealFlagType BankRepealFlag;
    /// <summary>
    /// 期商冲正标志
    /// </summary>
    [Description("期商冲正标志")]
    public CTPStockBrokerRepealFlagType BrokerRepealFlag;
    /// <summary>
    /// 被冲正平台流水号
    /// </summary>
    [Description("被冲正平台流水号")]
    public int PlateRepealSerial;
    /// <summary>
    /// 被冲正银行流水号
    /// </summary>
    [Description("被冲正银行流水号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String BankRepealSerial;
    /// <summary>
    /// 被冲正期货流水号
    /// </summary>
    [Description("被冲正期货流水号")]
    public int FutureRepealSerial;
    /// <summary>
    /// 业务功能码
    /// </summary>
    [Description("业务功能码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public String TradeCode;
    /// <summary>
    /// 银行代码
    /// </summary>
    [Description("银行代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String BankID;
    /// <summary>
    /// 银行分支机构代码
    /// </summary>
    [Description("银行分支机构代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public String BankBranchID;
    /// <summary>
    /// 期商代码
    /// </summary>
    [Description("期商代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 期商分支机构代码
    /// </summary>
    [Description("期商分支机构代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String BrokerBranchID;
    /// <summary>
    /// 交易日期
    /// </summary>
    [Description("交易日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeDate;
    /// <summary>
    /// 交易时间
    /// </summary>
    [Description("交易时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeTime;
    /// <summary>
    /// 银行流水号
    /// </summary>
    [Description("银行流水号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String BankSerial;
    /// <summary>
    /// 交易系统日期 
    /// </summary>
    [Description("交易系统日期 ")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradingDay;
    /// <summary>
    /// 银期平台消息流水号
    /// </summary>
    [Description("银期平台消息流水号")]
    public int PlateSerial;
    /// <summary>
    /// 最后分片标志
    /// </summary>
    [Description("最后分片标志")]
    public CTPStockLastFragmentType LastFragment;
    /// <summary>
    /// 会话号
    /// </summary>
    [Description("会话号")]
    public int SessionID;
    /// <summary>
    /// 客户姓名
    /// </summary>
    [Description("客户姓名")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
    public String CustomerName;
    /// <summary>
    /// 证件类型
    /// </summary>
    [Description("证件类型")]
    public CTPStockIdCardType IdCardType;
    /// <summary>
    /// 证件号码
    /// </summary>
    [Description("证件号码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
    public String IdentifiedCardNo;
    /// <summary>
    /// 客户类型
    /// </summary>
    [Description("客户类型")]
    public CTPStockCustType CustType;
    /// <summary>
    /// 银行帐号
    /// </summary>
    [Description("银行帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String BankAccount;
    /// <summary>
    /// 银行密码
    /// </summary>
    [Description("银行密码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String BankPassWord;
    /// <summary>
    /// 投资者帐号
    /// </summary>
    [Description("投资者帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String AccountID;
    /// <summary>
    /// 期货密码
    /// </summary>
    [Description("期货密码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String Password;
    /// <summary>
    /// 安装编号
    /// </summary>
    [Description("安装编号")]
    public int InstallID;
    /// <summary>
    /// 期货公司流水号
    /// </summary>
    [Description("期货公司流水号")]
    public int FutureSerial;
    /// <summary>
    /// 用户标识
    /// </summary>
    [Description("用户标识")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;
    /// <summary>
    /// 验证客户证件号码标志
    /// </summary>
    [Description("验证客户证件号码标志")]
    public CTPStockYesNoIndicatorType VerifyCertNoFlag;
    /// <summary>
    /// 币种代码
    /// </summary>
    [Description("币种代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String CurrencyID;
    /// <summary>
    /// 转帐金额
    /// </summary>
    [Description("转帐金额")]
    public double TradeAmount;
    /// <summary>
    /// 期货可取金额
    /// </summary>
    [Description("期货可取金额")]
    public double FutureFetchAmount;
    /// <summary>
    /// 费用支付标志
    /// </summary>
    [Description("费用支付标志")]
    public CTPStockFeePayFlagType FeePayFlag;
    /// <summary>
    /// 应收客户费用
    /// </summary>
    [Description("应收客户费用")]
    public double CustFee;
    /// <summary>
    /// 应收期货公司费用
    /// </summary>
    [Description("应收期货公司费用")]
    public double BrokerFee;
    /// <summary>
    /// 发送方给接收方的消息
    /// </summary>
    [Description("发送方给接收方的消息")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
    public String Message;
    /// <summary>
    /// 摘要
    /// </summary>
    [Description("摘要")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
    public String Digest;
    /// <summary>
    /// 银行帐号类型
    /// </summary>
    [Description("银行帐号类型")]
    public CTPStockBankAccType BankAccType;
    /// <summary>
    /// 渠道标志
    /// </summary>
    [Description("渠道标志")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public String DeviceID;
    /// <summary>
    /// 期货单位帐号类型
    /// </summary>
    [Description("期货单位帐号类型")]
    public CTPStockBankAccType BankSecuAccType;
    /// <summary>
    /// 期货公司银行编码
    /// </summary>
    [Description("期货公司银行编码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
    public String BrokerIDByBank;
    /// <summary>
    /// 期货单位帐号
    /// </summary>
    [Description("期货单位帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String BankSecuAcc;
    /// <summary>
    /// 银行密码标志
    /// </summary>
    [Description("银行密码标志")]
    public CTPStockPwdFlagType BankPwdFlag;
    /// <summary>
    /// 期货资金密码核对标志
    /// </summary>
    [Description("期货资金密码核对标志")]
    public CTPStockPwdFlagType SecuPwdFlag;
    /// <summary>
    /// 交易柜员
    /// </summary>
    [Description("交易柜员")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
    public String OperNo;
    /// <summary>
    /// 请求编号
    /// </summary>
    [Description("请求编号")]
    public int RequestID;
    /// <summary>
    /// 交易ID
    /// </summary>
    [Description("交易ID")]
    public int TID;
    /// <summary>
    /// 转账交易状态
    /// </summary>
    [Description("转账交易状态")]
    public CTPStockTransferStatusType TransferStatus;

  };

  /// <summary>
  /// 冲正响应
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcRspRepealField
  {
    /// <summary>
    /// 冲正时间间隔
    /// </summary>
    [Description("冲正时间间隔")]
    public int RepealTimeInterval;
    /// <summary>
    /// 已经冲正次数
    /// </summary>
    [Description("已经冲正次数")]
    public int RepealedTimes;
    /// <summary>
    /// 银行冲正标志
    /// </summary>
    [Description("银行冲正标志")]
    public CTPStockBankRepealFlagType BankRepealFlag;
    /// <summary>
    /// 期商冲正标志
    /// </summary>
    [Description("期商冲正标志")]
    public CTPStockBrokerRepealFlagType BrokerRepealFlag;
    /// <summary>
    /// 被冲正平台流水号
    /// </summary>
    [Description("被冲正平台流水号")]
    public int PlateRepealSerial;
    /// <summary>
    /// 被冲正银行流水号
    /// </summary>
    [Description("被冲正银行流水号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String BankRepealSerial;
    /// <summary>
    /// 被冲正期货流水号
    /// </summary>
    [Description("被冲正期货流水号")]
    public int FutureRepealSerial;
    /// <summary>
    /// 业务功能码
    /// </summary>
    [Description("业务功能码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public String TradeCode;
    /// <summary>
    /// 银行代码
    /// </summary>
    [Description("银行代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String BankID;
    /// <summary>
    /// 银行分支机构代码
    /// </summary>
    [Description("银行分支机构代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public String BankBranchID;
    /// <summary>
    /// 期商代码
    /// </summary>
    [Description("期商代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 期商分支机构代码
    /// </summary>
    [Description("期商分支机构代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String BrokerBranchID;
    /// <summary>
    /// 交易日期
    /// </summary>
    [Description("交易日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeDate;
    /// <summary>
    /// 交易时间
    /// </summary>
    [Description("交易时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeTime;
    /// <summary>
    /// 银行流水号
    /// </summary>
    [Description("银行流水号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String BankSerial;
    /// <summary>
    /// 交易系统日期 
    /// </summary>
    [Description("交易系统日期 ")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradingDay;
    /// <summary>
    /// 银期平台消息流水号
    /// </summary>
    [Description("银期平台消息流水号")]
    public int PlateSerial;
    /// <summary>
    /// 最后分片标志
    /// </summary>
    [Description("最后分片标志")]
    public CTPStockLastFragmentType LastFragment;
    /// <summary>
    /// 会话号
    /// </summary>
    [Description("会话号")]
    public int SessionID;
    /// <summary>
    /// 客户姓名
    /// </summary>
    [Description("客户姓名")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
    public String CustomerName;
    /// <summary>
    /// 证件类型
    /// </summary>
    [Description("证件类型")]
    public CTPStockIdCardType IdCardType;
    /// <summary>
    /// 证件号码
    /// </summary>
    [Description("证件号码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
    public String IdentifiedCardNo;
    /// <summary>
    /// 客户类型
    /// </summary>
    [Description("客户类型")]
    public CTPStockCustType CustType;
    /// <summary>
    /// 银行帐号
    /// </summary>
    [Description("银行帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String BankAccount;
    /// <summary>
    /// 银行密码
    /// </summary>
    [Description("银行密码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String BankPassWord;
    /// <summary>
    /// 投资者帐号
    /// </summary>
    [Description("投资者帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String AccountID;
    /// <summary>
    /// 期货密码
    /// </summary>
    [Description("期货密码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String Password;
    /// <summary>
    /// 安装编号
    /// </summary>
    [Description("安装编号")]
    public int InstallID;
    /// <summary>
    /// 期货公司流水号
    /// </summary>
    [Description("期货公司流水号")]
    public int FutureSerial;
    /// <summary>
    /// 用户标识
    /// </summary>
    [Description("用户标识")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;
    /// <summary>
    /// 验证客户证件号码标志
    /// </summary>
    [Description("验证客户证件号码标志")]
    public CTPStockYesNoIndicatorType VerifyCertNoFlag;
    /// <summary>
    /// 币种代码
    /// </summary>
    [Description("币种代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String CurrencyID;
    /// <summary>
    /// 转帐金额
    /// </summary>
    [Description("转帐金额")]
    public double TradeAmount;
    /// <summary>
    /// 期货可取金额
    /// </summary>
    [Description("期货可取金额")]
    public double FutureFetchAmount;
    /// <summary>
    /// 费用支付标志
    /// </summary>
    [Description("费用支付标志")]
    public CTPStockFeePayFlagType FeePayFlag;
    /// <summary>
    /// 应收客户费用
    /// </summary>
    [Description("应收客户费用")]
    public double CustFee;
    /// <summary>
    /// 应收期货公司费用
    /// </summary>
    [Description("应收期货公司费用")]
    public double BrokerFee;
    /// <summary>
    /// 发送方给接收方的消息
    /// </summary>
    [Description("发送方给接收方的消息")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
    public String Message;
    /// <summary>
    /// 摘要
    /// </summary>
    [Description("摘要")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
    public String Digest;
    /// <summary>
    /// 银行帐号类型
    /// </summary>
    [Description("银行帐号类型")]
    public CTPStockBankAccType BankAccType;
    /// <summary>
    /// 渠道标志
    /// </summary>
    [Description("渠道标志")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public String DeviceID;
    /// <summary>
    /// 期货单位帐号类型
    /// </summary>
    [Description("期货单位帐号类型")]
    public CTPStockBankAccType BankSecuAccType;
    /// <summary>
    /// 期货公司银行编码
    /// </summary>
    [Description("期货公司银行编码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
    public String BrokerIDByBank;
    /// <summary>
    /// 期货单位帐号
    /// </summary>
    [Description("期货单位帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String BankSecuAcc;
    /// <summary>
    /// 银行密码标志
    /// </summary>
    [Description("银行密码标志")]
    public CTPStockPwdFlagType BankPwdFlag;
    /// <summary>
    /// 期货资金密码核对标志
    /// </summary>
    [Description("期货资金密码核对标志")]
    public CTPStockPwdFlagType SecuPwdFlag;
    /// <summary>
    /// 交易柜员
    /// </summary>
    [Description("交易柜员")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
    public String OperNo;
    /// <summary>
    /// 请求编号
    /// </summary>
    [Description("请求编号")]
    public int RequestID;
    /// <summary>
    /// 交易ID
    /// </summary>
    [Description("交易ID")]
    public int TID;
    /// <summary>
    /// 转账交易状态
    /// </summary>
    [Description("转账交易状态")]
    public CTPStockTransferStatusType TransferStatus;
    /// <summary>
    /// 错误代码
    /// </summary>
    [Description("错误代码")]
    public int ErrorID;
    /// <summary>
    /// 错误信息
    /// </summary>
    [Description("错误信息")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
    public String ErrorMsg;

  };

  /// <summary>
  /// 查询账户信息请求
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcReqQueryAccountField
  {
    /// <summary>
    /// 业务功能码
    /// </summary>
    [Description("业务功能码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public String TradeCode;
    /// <summary>
    /// 银行代码
    /// </summary>
    [Description("银行代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String BankID;
    /// <summary>
    /// 银行分支机构代码
    /// </summary>
    [Description("银行分支机构代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public String BankBranchID;
    /// <summary>
    /// 期商代码
    /// </summary>
    [Description("期商代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 期商分支机构代码
    /// </summary>
    [Description("期商分支机构代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String BrokerBranchID;
    /// <summary>
    /// 交易日期
    /// </summary>
    [Description("交易日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeDate;
    /// <summary>
    /// 交易时间
    /// </summary>
    [Description("交易时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeTime;
    /// <summary>
    /// 银行流水号
    /// </summary>
    [Description("银行流水号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String BankSerial;
    /// <summary>
    /// 交易系统日期 
    /// </summary>
    [Description("交易系统日期 ")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradingDay;
    /// <summary>
    /// 银期平台消息流水号
    /// </summary>
    [Description("银期平台消息流水号")]
    public int PlateSerial;
    /// <summary>
    /// 最后分片标志
    /// </summary>
    [Description("最后分片标志")]
    public CTPStockLastFragmentType LastFragment;
    /// <summary>
    /// 会话号
    /// </summary>
    [Description("会话号")]
    public int SessionID;
    /// <summary>
    /// 客户姓名
    /// </summary>
    [Description("客户姓名")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
    public String CustomerName;
    /// <summary>
    /// 证件类型
    /// </summary>
    [Description("证件类型")]
    public CTPStockIdCardType IdCardType;
    /// <summary>
    /// 证件号码
    /// </summary>
    [Description("证件号码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
    public String IdentifiedCardNo;
    /// <summary>
    /// 客户类型
    /// </summary>
    [Description("客户类型")]
    public CTPStockCustType CustType;
    /// <summary>
    /// 银行帐号
    /// </summary>
    [Description("银行帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String BankAccount;
    /// <summary>
    /// 银行密码
    /// </summary>
    [Description("银行密码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String BankPassWord;
    /// <summary>
    /// 投资者帐号
    /// </summary>
    [Description("投资者帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String AccountID;
    /// <summary>
    /// 期货密码
    /// </summary>
    [Description("期货密码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String Password;
    /// <summary>
    /// 期货公司流水号
    /// </summary>
    [Description("期货公司流水号")]
    public int FutureSerial;
    /// <summary>
    /// 安装编号
    /// </summary>
    [Description("安装编号")]
    public int InstallID;
    /// <summary>
    /// 用户标识
    /// </summary>
    [Description("用户标识")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;
    /// <summary>
    /// 验证客户证件号码标志
    /// </summary>
    [Description("验证客户证件号码标志")]
    public CTPStockYesNoIndicatorType VerifyCertNoFlag;
    /// <summary>
    /// 币种代码
    /// </summary>
    [Description("币种代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String CurrencyID;
    /// <summary>
    /// 摘要
    /// </summary>
    [Description("摘要")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
    public String Digest;
    /// <summary>
    /// 银行帐号类型
    /// </summary>
    [Description("银行帐号类型")]
    public CTPStockBankAccType BankAccType;
    /// <summary>
    /// 渠道标志
    /// </summary>
    [Description("渠道标志")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public String DeviceID;
    /// <summary>
    /// 期货单位帐号类型
    /// </summary>
    [Description("期货单位帐号类型")]
    public CTPStockBankAccType BankSecuAccType;
    /// <summary>
    /// 期货公司银行编码
    /// </summary>
    [Description("期货公司银行编码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
    public String BrokerIDByBank;
    /// <summary>
    /// 期货单位帐号
    /// </summary>
    [Description("期货单位帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String BankSecuAcc;
    /// <summary>
    /// 银行密码标志
    /// </summary>
    [Description("银行密码标志")]
    public CTPStockPwdFlagType BankPwdFlag;
    /// <summary>
    /// 期货资金密码核对标志
    /// </summary>
    [Description("期货资金密码核对标志")]
    public CTPStockPwdFlagType SecuPwdFlag;
    /// <summary>
    /// 交易柜员
    /// </summary>
    [Description("交易柜员")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
    public String OperNo;
    /// <summary>
    /// 请求编号
    /// </summary>
    [Description("请求编号")]
    public int RequestID;
    /// <summary>
    /// 交易ID
    /// </summary>
    [Description("交易ID")]
    public int TID;

  };

  /// <summary>
  /// 查询账户信息响应
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcRspQueryAccountField
  {
    /// <summary>
    /// 业务功能码
    /// </summary>
    [Description("业务功能码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public String TradeCode;
    /// <summary>
    /// 银行代码
    /// </summary>
    [Description("银行代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String BankID;
    /// <summary>
    /// 银行分支机构代码
    /// </summary>
    [Description("银行分支机构代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public String BankBranchID;
    /// <summary>
    /// 期商代码
    /// </summary>
    [Description("期商代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 期商分支机构代码
    /// </summary>
    [Description("期商分支机构代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String BrokerBranchID;
    /// <summary>
    /// 交易日期
    /// </summary>
    [Description("交易日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeDate;
    /// <summary>
    /// 交易时间
    /// </summary>
    [Description("交易时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeTime;
    /// <summary>
    /// 银行流水号
    /// </summary>
    [Description("银行流水号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String BankSerial;
    /// <summary>
    /// 交易系统日期 
    /// </summary>
    [Description("交易系统日期 ")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradingDay;
    /// <summary>
    /// 银期平台消息流水号
    /// </summary>
    [Description("银期平台消息流水号")]
    public int PlateSerial;
    /// <summary>
    /// 最后分片标志
    /// </summary>
    [Description("最后分片标志")]
    public CTPStockLastFragmentType LastFragment;
    /// <summary>
    /// 会话号
    /// </summary>
    [Description("会话号")]
    public int SessionID;
    /// <summary>
    /// 客户姓名
    /// </summary>
    [Description("客户姓名")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
    public String CustomerName;
    /// <summary>
    /// 证件类型
    /// </summary>
    [Description("证件类型")]
    public CTPStockIdCardType IdCardType;
    /// <summary>
    /// 证件号码
    /// </summary>
    [Description("证件号码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
    public String IdentifiedCardNo;
    /// <summary>
    /// 客户类型
    /// </summary>
    [Description("客户类型")]
    public CTPStockCustType CustType;
    /// <summary>
    /// 银行帐号
    /// </summary>
    [Description("银行帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String BankAccount;
    /// <summary>
    /// 银行密码
    /// </summary>
    [Description("银行密码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String BankPassWord;
    /// <summary>
    /// 投资者帐号
    /// </summary>
    [Description("投资者帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String AccountID;
    /// <summary>
    /// 期货密码
    /// </summary>
    [Description("期货密码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String Password;
    /// <summary>
    /// 期货公司流水号
    /// </summary>
    [Description("期货公司流水号")]
    public int FutureSerial;
    /// <summary>
    /// 安装编号
    /// </summary>
    [Description("安装编号")]
    public int InstallID;
    /// <summary>
    /// 用户标识
    /// </summary>
    [Description("用户标识")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;
    /// <summary>
    /// 验证客户证件号码标志
    /// </summary>
    [Description("验证客户证件号码标志")]
    public CTPStockYesNoIndicatorType VerifyCertNoFlag;
    /// <summary>
    /// 币种代码
    /// </summary>
    [Description("币种代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String CurrencyID;
    /// <summary>
    /// 摘要
    /// </summary>
    [Description("摘要")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
    public String Digest;
    /// <summary>
    /// 银行帐号类型
    /// </summary>
    [Description("银行帐号类型")]
    public CTPStockBankAccType BankAccType;
    /// <summary>
    /// 渠道标志
    /// </summary>
    [Description("渠道标志")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public String DeviceID;
    /// <summary>
    /// 期货单位帐号类型
    /// </summary>
    [Description("期货单位帐号类型")]
    public CTPStockBankAccType BankSecuAccType;
    /// <summary>
    /// 期货公司银行编码
    /// </summary>
    [Description("期货公司银行编码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
    public String BrokerIDByBank;
    /// <summary>
    /// 期货单位帐号
    /// </summary>
    [Description("期货单位帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String BankSecuAcc;
    /// <summary>
    /// 银行密码标志
    /// </summary>
    [Description("银行密码标志")]
    public CTPStockPwdFlagType BankPwdFlag;
    /// <summary>
    /// 期货资金密码核对标志
    /// </summary>
    [Description("期货资金密码核对标志")]
    public CTPStockPwdFlagType SecuPwdFlag;
    /// <summary>
    /// 交易柜员
    /// </summary>
    [Description("交易柜员")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
    public String OperNo;
    /// <summary>
    /// 请求编号
    /// </summary>
    [Description("请求编号")]
    public int RequestID;
    /// <summary>
    /// 交易ID
    /// </summary>
    [Description("交易ID")]
    public int TID;
    /// <summary>
    /// 银行可用金额
    /// </summary>
    [Description("银行可用金额")]
    public double BankUseAmount;
    /// <summary>
    /// 银行可取金额
    /// </summary>
    [Description("银行可取金额")]
    public double BankFetchAmount;

  };

  /// <summary>
  /// 期商签到签退
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcFutureSignIOField
  {
    /// <summary>
    /// 业务功能码
    /// </summary>
    [Description("业务功能码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public String TradeCode;
    /// <summary>
    /// 银行代码
    /// </summary>
    [Description("银行代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String BankID;
    /// <summary>
    /// 银行分支机构代码
    /// </summary>
    [Description("银行分支机构代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public String BankBranchID;
    /// <summary>
    /// 期商代码
    /// </summary>
    [Description("期商代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 期商分支机构代码
    /// </summary>
    [Description("期商分支机构代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String BrokerBranchID;
    /// <summary>
    /// 交易日期
    /// </summary>
    [Description("交易日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeDate;
    /// <summary>
    /// 交易时间
    /// </summary>
    [Description("交易时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeTime;
    /// <summary>
    /// 银行流水号
    /// </summary>
    [Description("银行流水号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String BankSerial;
    /// <summary>
    /// 交易系统日期 
    /// </summary>
    [Description("交易系统日期 ")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradingDay;
    /// <summary>
    /// 银期平台消息流水号
    /// </summary>
    [Description("银期平台消息流水号")]
    public int PlateSerial;
    /// <summary>
    /// 最后分片标志
    /// </summary>
    [Description("最后分片标志")]
    public CTPStockLastFragmentType LastFragment;
    /// <summary>
    /// 会话号
    /// </summary>
    [Description("会话号")]
    public int SessionID;
    /// <summary>
    /// 安装编号
    /// </summary>
    [Description("安装编号")]
    public int InstallID;
    /// <summary>
    /// 用户标识
    /// </summary>
    [Description("用户标识")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;
    /// <summary>
    /// 摘要
    /// </summary>
    [Description("摘要")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
    public String Digest;
    /// <summary>
    /// 币种代码
    /// </summary>
    [Description("币种代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String CurrencyID;
    /// <summary>
    /// 渠道标志
    /// </summary>
    [Description("渠道标志")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public String DeviceID;
    /// <summary>
    /// 期货公司银行编码
    /// </summary>
    [Description("期货公司银行编码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
    public String BrokerIDByBank;
    /// <summary>
    /// 交易柜员
    /// </summary>
    [Description("交易柜员")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
    public String OperNo;
    /// <summary>
    /// 请求编号
    /// </summary>
    [Description("请求编号")]
    public int RequestID;
    /// <summary>
    /// 交易ID
    /// </summary>
    [Description("交易ID")]
    public int TID;

  };

  /// <summary>
  /// 期商签到响应
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcRspFutureSignInField
  {
    /// <summary>
    /// 业务功能码
    /// </summary>
    [Description("业务功能码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public String TradeCode;
    /// <summary>
    /// 银行代码
    /// </summary>
    [Description("银行代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String BankID;
    /// <summary>
    /// 银行分支机构代码
    /// </summary>
    [Description("银行分支机构代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public String BankBranchID;
    /// <summary>
    /// 期商代码
    /// </summary>
    [Description("期商代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 期商分支机构代码
    /// </summary>
    [Description("期商分支机构代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String BrokerBranchID;
    /// <summary>
    /// 交易日期
    /// </summary>
    [Description("交易日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeDate;
    /// <summary>
    /// 交易时间
    /// </summary>
    [Description("交易时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeTime;
    /// <summary>
    /// 银行流水号
    /// </summary>
    [Description("银行流水号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String BankSerial;
    /// <summary>
    /// 交易系统日期 
    /// </summary>
    [Description("交易系统日期 ")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradingDay;
    /// <summary>
    /// 银期平台消息流水号
    /// </summary>
    [Description("银期平台消息流水号")]
    public int PlateSerial;
    /// <summary>
    /// 最后分片标志
    /// </summary>
    [Description("最后分片标志")]
    public CTPStockLastFragmentType LastFragment;
    /// <summary>
    /// 会话号
    /// </summary>
    [Description("会话号")]
    public int SessionID;
    /// <summary>
    /// 安装编号
    /// </summary>
    [Description("安装编号")]
    public int InstallID;
    /// <summary>
    /// 用户标识
    /// </summary>
    [Description("用户标识")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;
    /// <summary>
    /// 摘要
    /// </summary>
    [Description("摘要")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
    public String Digest;
    /// <summary>
    /// 币种代码
    /// </summary>
    [Description("币种代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String CurrencyID;
    /// <summary>
    /// 渠道标志
    /// </summary>
    [Description("渠道标志")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public String DeviceID;
    /// <summary>
    /// 期货公司银行编码
    /// </summary>
    [Description("期货公司银行编码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
    public String BrokerIDByBank;
    /// <summary>
    /// 交易柜员
    /// </summary>
    [Description("交易柜员")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
    public String OperNo;
    /// <summary>
    /// 请求编号
    /// </summary>
    [Description("请求编号")]
    public int RequestID;
    /// <summary>
    /// 交易ID
    /// </summary>
    [Description("交易ID")]
    public int TID;
    /// <summary>
    /// 错误代码
    /// </summary>
    [Description("错误代码")]
    public int ErrorID;
    /// <summary>
    /// 错误信息
    /// </summary>
    [Description("错误信息")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
    public String ErrorMsg;
    /// <summary>
    /// PIN密钥
    /// </summary>
    [Description("PIN密钥")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
    public String PinKey;
    /// <summary>
    /// MAC密钥
    /// </summary>
    [Description("MAC密钥")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
    public String MacKey;

  };

  /// <summary>
  /// 期商签退请求
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcReqFutureSignOutField
  {
    /// <summary>
    /// 业务功能码
    /// </summary>
    [Description("业务功能码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public String TradeCode;
    /// <summary>
    /// 银行代码
    /// </summary>
    [Description("银行代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String BankID;
    /// <summary>
    /// 银行分支机构代码
    /// </summary>
    [Description("银行分支机构代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public String BankBranchID;
    /// <summary>
    /// 期商代码
    /// </summary>
    [Description("期商代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 期商分支机构代码
    /// </summary>
    [Description("期商分支机构代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String BrokerBranchID;
    /// <summary>
    /// 交易日期
    /// </summary>
    [Description("交易日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeDate;
    /// <summary>
    /// 交易时间
    /// </summary>
    [Description("交易时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeTime;
    /// <summary>
    /// 银行流水号
    /// </summary>
    [Description("银行流水号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String BankSerial;
    /// <summary>
    /// 交易系统日期 
    /// </summary>
    [Description("交易系统日期 ")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradingDay;
    /// <summary>
    /// 银期平台消息流水号
    /// </summary>
    [Description("银期平台消息流水号")]
    public int PlateSerial;
    /// <summary>
    /// 最后分片标志
    /// </summary>
    [Description("最后分片标志")]
    public CTPStockLastFragmentType LastFragment;
    /// <summary>
    /// 会话号
    /// </summary>
    [Description("会话号")]
    public int SessionID;
    /// <summary>
    /// 安装编号
    /// </summary>
    [Description("安装编号")]
    public int InstallID;
    /// <summary>
    /// 用户标识
    /// </summary>
    [Description("用户标识")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;
    /// <summary>
    /// 摘要
    /// </summary>
    [Description("摘要")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
    public String Digest;
    /// <summary>
    /// 币种代码
    /// </summary>
    [Description("币种代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String CurrencyID;
    /// <summary>
    /// 渠道标志
    /// </summary>
    [Description("渠道标志")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public String DeviceID;
    /// <summary>
    /// 期货公司银行编码
    /// </summary>
    [Description("期货公司银行编码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
    public String BrokerIDByBank;
    /// <summary>
    /// 交易柜员
    /// </summary>
    [Description("交易柜员")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
    public String OperNo;
    /// <summary>
    /// 请求编号
    /// </summary>
    [Description("请求编号")]
    public int RequestID;
    /// <summary>
    /// 交易ID
    /// </summary>
    [Description("交易ID")]
    public int TID;

  };

  /// <summary>
  /// 期商签退响应
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcRspFutureSignOutField
  {
    /// <summary>
    /// 业务功能码
    /// </summary>
    [Description("业务功能码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public String TradeCode;
    /// <summary>
    /// 银行代码
    /// </summary>
    [Description("银行代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String BankID;
    /// <summary>
    /// 银行分支机构代码
    /// </summary>
    [Description("银行分支机构代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public String BankBranchID;
    /// <summary>
    /// 期商代码
    /// </summary>
    [Description("期商代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 期商分支机构代码
    /// </summary>
    [Description("期商分支机构代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String BrokerBranchID;
    /// <summary>
    /// 交易日期
    /// </summary>
    [Description("交易日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeDate;
    /// <summary>
    /// 交易时间
    /// </summary>
    [Description("交易时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeTime;
    /// <summary>
    /// 银行流水号
    /// </summary>
    [Description("银行流水号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String BankSerial;
    /// <summary>
    /// 交易系统日期 
    /// </summary>
    [Description("交易系统日期 ")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradingDay;
    /// <summary>
    /// 银期平台消息流水号
    /// </summary>
    [Description("银期平台消息流水号")]
    public int PlateSerial;
    /// <summary>
    /// 最后分片标志
    /// </summary>
    [Description("最后分片标志")]
    public CTPStockLastFragmentType LastFragment;
    /// <summary>
    /// 会话号
    /// </summary>
    [Description("会话号")]
    public int SessionID;
    /// <summary>
    /// 安装编号
    /// </summary>
    [Description("安装编号")]
    public int InstallID;
    /// <summary>
    /// 用户标识
    /// </summary>
    [Description("用户标识")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;
    /// <summary>
    /// 摘要
    /// </summary>
    [Description("摘要")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
    public String Digest;
    /// <summary>
    /// 币种代码
    /// </summary>
    [Description("币种代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String CurrencyID;
    /// <summary>
    /// 渠道标志
    /// </summary>
    [Description("渠道标志")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public String DeviceID;
    /// <summary>
    /// 期货公司银行编码
    /// </summary>
    [Description("期货公司银行编码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
    public String BrokerIDByBank;
    /// <summary>
    /// 交易柜员
    /// </summary>
    [Description("交易柜员")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
    public String OperNo;
    /// <summary>
    /// 请求编号
    /// </summary>
    [Description("请求编号")]
    public int RequestID;
    /// <summary>
    /// 交易ID
    /// </summary>
    [Description("交易ID")]
    public int TID;
    /// <summary>
    /// 错误代码
    /// </summary>
    [Description("错误代码")]
    public int ErrorID;
    /// <summary>
    /// 错误信息
    /// </summary>
    [Description("错误信息")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
    public String ErrorMsg;

  };

  /// <summary>
  /// 查询指定流水号的交易结果请求
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcReqQueryTradeResultBySerialField
  {
    /// <summary>
    /// 业务功能码
    /// </summary>
    [Description("业务功能码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public String TradeCode;
    /// <summary>
    /// 银行代码
    /// </summary>
    [Description("银行代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String BankID;
    /// <summary>
    /// 银行分支机构代码
    /// </summary>
    [Description("银行分支机构代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public String BankBranchID;
    /// <summary>
    /// 期商代码
    /// </summary>
    [Description("期商代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 期商分支机构代码
    /// </summary>
    [Description("期商分支机构代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String BrokerBranchID;
    /// <summary>
    /// 交易日期
    /// </summary>
    [Description("交易日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeDate;
    /// <summary>
    /// 交易时间
    /// </summary>
    [Description("交易时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeTime;
    /// <summary>
    /// 银行流水号
    /// </summary>
    [Description("银行流水号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String BankSerial;
    /// <summary>
    /// 交易系统日期 
    /// </summary>
    [Description("交易系统日期 ")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradingDay;
    /// <summary>
    /// 银期平台消息流水号
    /// </summary>
    [Description("银期平台消息流水号")]
    public int PlateSerial;
    /// <summary>
    /// 最后分片标志
    /// </summary>
    [Description("最后分片标志")]
    public CTPStockLastFragmentType LastFragment;
    /// <summary>
    /// 会话号
    /// </summary>
    [Description("会话号")]
    public int SessionID;
    /// <summary>
    /// 流水号
    /// </summary>
    [Description("流水号")]
    public int Reference;
    /// <summary>
    /// 本流水号发布者的机构类型
    /// </summary>
    [Description("本流水号发布者的机构类型")]
    public CTPStockInstitutionType RefrenceIssureType;
    /// <summary>
    /// 本流水号发布者机构编码
    /// </summary>
    [Description("本流水号发布者机构编码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
    public String RefrenceIssure;
    /// <summary>
    /// 客户姓名
    /// </summary>
    [Description("客户姓名")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
    public String CustomerName;
    /// <summary>
    /// 证件类型
    /// </summary>
    [Description("证件类型")]
    public CTPStockIdCardType IdCardType;
    /// <summary>
    /// 证件号码
    /// </summary>
    [Description("证件号码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
    public String IdentifiedCardNo;
    /// <summary>
    /// 客户类型
    /// </summary>
    [Description("客户类型")]
    public CTPStockCustType CustType;
    /// <summary>
    /// 银行帐号
    /// </summary>
    [Description("银行帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String BankAccount;
    /// <summary>
    /// 银行密码
    /// </summary>
    [Description("银行密码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String BankPassWord;
    /// <summary>
    /// 投资者帐号
    /// </summary>
    [Description("投资者帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String AccountID;
    /// <summary>
    /// 期货密码
    /// </summary>
    [Description("期货密码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String Password;
    /// <summary>
    /// 币种代码
    /// </summary>
    [Description("币种代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String CurrencyID;
    /// <summary>
    /// 转帐金额
    /// </summary>
    [Description("转帐金额")]
    public double TradeAmount;
    /// <summary>
    /// 摘要
    /// </summary>
    [Description("摘要")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
    public String Digest;

  };

  /// <summary>
  /// 查询指定流水号的交易结果响应
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcRspQueryTradeResultBySerialField
  {
    /// <summary>
    /// 业务功能码
    /// </summary>
    [Description("业务功能码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public String TradeCode;
    /// <summary>
    /// 银行代码
    /// </summary>
    [Description("银行代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String BankID;
    /// <summary>
    /// 银行分支机构代码
    /// </summary>
    [Description("银行分支机构代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public String BankBranchID;
    /// <summary>
    /// 期商代码
    /// </summary>
    [Description("期商代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 期商分支机构代码
    /// </summary>
    [Description("期商分支机构代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String BrokerBranchID;
    /// <summary>
    /// 交易日期
    /// </summary>
    [Description("交易日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeDate;
    /// <summary>
    /// 交易时间
    /// </summary>
    [Description("交易时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeTime;
    /// <summary>
    /// 银行流水号
    /// </summary>
    [Description("银行流水号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String BankSerial;
    /// <summary>
    /// 交易系统日期 
    /// </summary>
    [Description("交易系统日期 ")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradingDay;
    /// <summary>
    /// 银期平台消息流水号
    /// </summary>
    [Description("银期平台消息流水号")]
    public int PlateSerial;
    /// <summary>
    /// 最后分片标志
    /// </summary>
    [Description("最后分片标志")]
    public CTPStockLastFragmentType LastFragment;
    /// <summary>
    /// 会话号
    /// </summary>
    [Description("会话号")]
    public int SessionID;
    /// <summary>
    /// 错误代码
    /// </summary>
    [Description("错误代码")]
    public int ErrorID;
    /// <summary>
    /// 错误信息
    /// </summary>
    [Description("错误信息")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
    public String ErrorMsg;
    /// <summary>
    /// 流水号
    /// </summary>
    [Description("流水号")]
    public int Reference;
    /// <summary>
    /// 本流水号发布者的机构类型
    /// </summary>
    [Description("本流水号发布者的机构类型")]
    public CTPStockInstitutionType RefrenceIssureType;
    /// <summary>
    /// 本流水号发布者机构编码
    /// </summary>
    [Description("本流水号发布者机构编码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
    public String RefrenceIssure;
    /// <summary>
    /// 原始返回代码
    /// </summary>
    [Description("原始返回代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public String OriginReturnCode;
    /// <summary>
    /// 原始返回码描述
    /// </summary>
    [Description("原始返回码描述")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
    public String OriginDescrInfoForReturnCode;
    /// <summary>
    /// 银行帐号
    /// </summary>
    [Description("银行帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String BankAccount;
    /// <summary>
    /// 银行密码
    /// </summary>
    [Description("银行密码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String BankPassWord;
    /// <summary>
    /// 投资者帐号
    /// </summary>
    [Description("投资者帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String AccountID;
    /// <summary>
    /// 期货密码
    /// </summary>
    [Description("期货密码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String Password;
    /// <summary>
    /// 币种代码
    /// </summary>
    [Description("币种代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String CurrencyID;
    /// <summary>
    /// 转帐金额
    /// </summary>
    [Description("转帐金额")]
    public double TradeAmount;
    /// <summary>
    /// 摘要
    /// </summary>
    [Description("摘要")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
    public String Digest;

  };

  /// <summary>
  /// 日终文件就绪请求
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcReqDayEndFileReadyField
  {
    /// <summary>
    /// 业务功能码
    /// </summary>
    [Description("业务功能码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public String TradeCode;
    /// <summary>
    /// 银行代码
    /// </summary>
    [Description("银行代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String BankID;
    /// <summary>
    /// 银行分支机构代码
    /// </summary>
    [Description("银行分支机构代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public String BankBranchID;
    /// <summary>
    /// 期商代码
    /// </summary>
    [Description("期商代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 期商分支机构代码
    /// </summary>
    [Description("期商分支机构代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String BrokerBranchID;
    /// <summary>
    /// 交易日期
    /// </summary>
    [Description("交易日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeDate;
    /// <summary>
    /// 交易时间
    /// </summary>
    [Description("交易时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeTime;
    /// <summary>
    /// 银行流水号
    /// </summary>
    [Description("银行流水号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String BankSerial;
    /// <summary>
    /// 交易系统日期 
    /// </summary>
    [Description("交易系统日期 ")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradingDay;
    /// <summary>
    /// 银期平台消息流水号
    /// </summary>
    [Description("银期平台消息流水号")]
    public int PlateSerial;
    /// <summary>
    /// 最后分片标志
    /// </summary>
    [Description("最后分片标志")]
    public CTPStockLastFragmentType LastFragment;
    /// <summary>
    /// 会话号
    /// </summary>
    [Description("会话号")]
    public int SessionID;
    /// <summary>
    /// 文件业务功能
    /// </summary>
    [Description("文件业务功能")]
    public CTPStockFileBusinessCodeType FileBusinessCode;
    /// <summary>
    /// 摘要
    /// </summary>
    [Description("摘要")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
    public String Digest;

  };

  /// <summary>
  /// 返回结果
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcReturnResultField
  {
    /// <summary>
    /// 返回代码
    /// </summary>
    [Description("返回代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public String ReturnCode;
    /// <summary>
    /// 返回码描述
    /// </summary>
    [Description("返回码描述")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
    public String DescrInfoForReturnCode;

  };

  /// <summary>
  /// 验证期货资金密码
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcVerifyFuturePasswordField
  {
    /// <summary>
    /// 业务功能码
    /// </summary>
    [Description("业务功能码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public String TradeCode;
    /// <summary>
    /// 银行代码
    /// </summary>
    [Description("银行代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String BankID;
    /// <summary>
    /// 银行分支机构代码
    /// </summary>
    [Description("银行分支机构代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public String BankBranchID;
    /// <summary>
    /// 期商代码
    /// </summary>
    [Description("期商代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 期商分支机构代码
    /// </summary>
    [Description("期商分支机构代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String BrokerBranchID;
    /// <summary>
    /// 交易日期
    /// </summary>
    [Description("交易日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeDate;
    /// <summary>
    /// 交易时间
    /// </summary>
    [Description("交易时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeTime;
    /// <summary>
    /// 银行流水号
    /// </summary>
    [Description("银行流水号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String BankSerial;
    /// <summary>
    /// 交易系统日期 
    /// </summary>
    [Description("交易系统日期 ")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradingDay;
    /// <summary>
    /// 银期平台消息流水号
    /// </summary>
    [Description("银期平台消息流水号")]
    public int PlateSerial;
    /// <summary>
    /// 最后分片标志
    /// </summary>
    [Description("最后分片标志")]
    public CTPStockLastFragmentType LastFragment;
    /// <summary>
    /// 会话号
    /// </summary>
    [Description("会话号")]
    public int SessionID;
    /// <summary>
    /// 投资者帐号
    /// </summary>
    [Description("投资者帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String AccountID;
    /// <summary>
    /// 期货密码
    /// </summary>
    [Description("期货密码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String Password;
    /// <summary>
    /// 银行帐号
    /// </summary>
    [Description("银行帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String BankAccount;
    /// <summary>
    /// 银行密码
    /// </summary>
    [Description("银行密码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String BankPassWord;
    /// <summary>
    /// 安装编号
    /// </summary>
    [Description("安装编号")]
    public int InstallID;
    /// <summary>
    /// 交易ID
    /// </summary>
    [Description("交易ID")]
    public int TID;

  };

  /// <summary>
  /// 验证客户信息
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcVerifyCustInfoField
  {
    /// <summary>
    /// 客户姓名
    /// </summary>
    [Description("客户姓名")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
    public String CustomerName;
    /// <summary>
    /// 证件类型
    /// </summary>
    [Description("证件类型")]
    public CTPStockIdCardType IdCardType;
    /// <summary>
    /// 证件号码
    /// </summary>
    [Description("证件号码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
    public String IdentifiedCardNo;
    /// <summary>
    /// 客户类型
    /// </summary>
    [Description("客户类型")]
    public CTPStockCustType CustType;

  };

  /// <summary>
  /// 验证期货资金密码和客户信息
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcVerifyFuturePasswordAndCustInfoField
  {
    /// <summary>
    /// 客户姓名
    /// </summary>
    [Description("客户姓名")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
    public String CustomerName;
    /// <summary>
    /// 证件类型
    /// </summary>
    [Description("证件类型")]
    public CTPStockIdCardType IdCardType;
    /// <summary>
    /// 证件号码
    /// </summary>
    [Description("证件号码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
    public String IdentifiedCardNo;
    /// <summary>
    /// 客户类型
    /// </summary>
    [Description("客户类型")]
    public CTPStockCustType CustType;
    /// <summary>
    /// 投资者帐号
    /// </summary>
    [Description("投资者帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String AccountID;
    /// <summary>
    /// 期货密码
    /// </summary>
    [Description("期货密码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String Password;

  };

  /// <summary>
  /// 验证期货资金密码和客户信息
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcDepositResultInformField
  {
    /// <summary>
    /// 出入金流水号，该流水号为银期报盘返回的流水号
    /// </summary>
    [Description("出入金流水号，该流水号为银期报盘返回的流水号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String DepositSeqNo;
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 入金金额
    /// </summary>
    [Description("入金金额")]
    public double Deposit;
    /// <summary>
    /// 请求编号
    /// </summary>
    [Description("请求编号")]
    public int RequestID;
    /// <summary>
    /// 返回代码
    /// </summary>
    [Description("返回代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public String ReturnCode;
    /// <summary>
    /// 返回码描述
    /// </summary>
    [Description("返回码描述")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
    public String DescrInfoForReturnCode;

  };

  /// <summary>
  /// 交易核心向银期报盘发出密钥同步请求
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcReqSyncKeyField
  {
    /// <summary>
    /// 业务功能码
    /// </summary>
    [Description("业务功能码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public String TradeCode;
    /// <summary>
    /// 银行代码
    /// </summary>
    [Description("银行代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String BankID;
    /// <summary>
    /// 银行分支机构代码
    /// </summary>
    [Description("银行分支机构代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public String BankBranchID;
    /// <summary>
    /// 期商代码
    /// </summary>
    [Description("期商代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 期商分支机构代码
    /// </summary>
    [Description("期商分支机构代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String BrokerBranchID;
    /// <summary>
    /// 交易日期
    /// </summary>
    [Description("交易日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeDate;
    /// <summary>
    /// 交易时间
    /// </summary>
    [Description("交易时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeTime;
    /// <summary>
    /// 银行流水号
    /// </summary>
    [Description("银行流水号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String BankSerial;
    /// <summary>
    /// 交易系统日期 
    /// </summary>
    [Description("交易系统日期 ")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradingDay;
    /// <summary>
    /// 银期平台消息流水号
    /// </summary>
    [Description("银期平台消息流水号")]
    public int PlateSerial;
    /// <summary>
    /// 最后分片标志
    /// </summary>
    [Description("最后分片标志")]
    public CTPStockLastFragmentType LastFragment;
    /// <summary>
    /// 会话号
    /// </summary>
    [Description("会话号")]
    public int SessionID;
    /// <summary>
    /// 安装编号
    /// </summary>
    [Description("安装编号")]
    public int InstallID;
    /// <summary>
    /// 用户标识
    /// </summary>
    [Description("用户标识")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;
    /// <summary>
    /// 交易核心给银期报盘的消息
    /// </summary>
    [Description("交易核心给银期报盘的消息")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
    public String Message;
    /// <summary>
    /// 渠道标志
    /// </summary>
    [Description("渠道标志")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public String DeviceID;
    /// <summary>
    /// 期货公司银行编码
    /// </summary>
    [Description("期货公司银行编码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
    public String BrokerIDByBank;
    /// <summary>
    /// 交易柜员
    /// </summary>
    [Description("交易柜员")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
    public String OperNo;
    /// <summary>
    /// 请求编号
    /// </summary>
    [Description("请求编号")]
    public int RequestID;
    /// <summary>
    /// 交易ID
    /// </summary>
    [Description("交易ID")]
    public int TID;

  };

  /// <summary>
  /// 交易核心向银期报盘发出密钥同步响应
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcRspSyncKeyField
  {
    /// <summary>
    /// 业务功能码
    /// </summary>
    [Description("业务功能码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public String TradeCode;
    /// <summary>
    /// 银行代码
    /// </summary>
    [Description("银行代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String BankID;
    /// <summary>
    /// 银行分支机构代码
    /// </summary>
    [Description("银行分支机构代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public String BankBranchID;
    /// <summary>
    /// 期商代码
    /// </summary>
    [Description("期商代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 期商分支机构代码
    /// </summary>
    [Description("期商分支机构代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String BrokerBranchID;
    /// <summary>
    /// 交易日期
    /// </summary>
    [Description("交易日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeDate;
    /// <summary>
    /// 交易时间
    /// </summary>
    [Description("交易时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeTime;
    /// <summary>
    /// 银行流水号
    /// </summary>
    [Description("银行流水号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String BankSerial;
    /// <summary>
    /// 交易系统日期 
    /// </summary>
    [Description("交易系统日期 ")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradingDay;
    /// <summary>
    /// 银期平台消息流水号
    /// </summary>
    [Description("银期平台消息流水号")]
    public int PlateSerial;
    /// <summary>
    /// 最后分片标志
    /// </summary>
    [Description("最后分片标志")]
    public CTPStockLastFragmentType LastFragment;
    /// <summary>
    /// 会话号
    /// </summary>
    [Description("会话号")]
    public int SessionID;
    /// <summary>
    /// 安装编号
    /// </summary>
    [Description("安装编号")]
    public int InstallID;
    /// <summary>
    /// 用户标识
    /// </summary>
    [Description("用户标识")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;
    /// <summary>
    /// 交易核心给银期报盘的消息
    /// </summary>
    [Description("交易核心给银期报盘的消息")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
    public String Message;
    /// <summary>
    /// 渠道标志
    /// </summary>
    [Description("渠道标志")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public String DeviceID;
    /// <summary>
    /// 期货公司银行编码
    /// </summary>
    [Description("期货公司银行编码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
    public String BrokerIDByBank;
    /// <summary>
    /// 交易柜员
    /// </summary>
    [Description("交易柜员")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
    public String OperNo;
    /// <summary>
    /// 请求编号
    /// </summary>
    [Description("请求编号")]
    public int RequestID;
    /// <summary>
    /// 交易ID
    /// </summary>
    [Description("交易ID")]
    public int TID;
    /// <summary>
    /// 错误代码
    /// </summary>
    [Description("错误代码")]
    public int ErrorID;
    /// <summary>
    /// 错误信息
    /// </summary>
    [Description("错误信息")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
    public String ErrorMsg;

  };

  /// <summary>
  /// 查询账户信息通知
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcNotifyQueryAccountField
  {
    /// <summary>
    /// 业务功能码
    /// </summary>
    [Description("业务功能码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public String TradeCode;
    /// <summary>
    /// 银行代码
    /// </summary>
    [Description("银行代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String BankID;
    /// <summary>
    /// 银行分支机构代码
    /// </summary>
    [Description("银行分支机构代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public String BankBranchID;
    /// <summary>
    /// 期商代码
    /// </summary>
    [Description("期商代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 期商分支机构代码
    /// </summary>
    [Description("期商分支机构代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String BrokerBranchID;
    /// <summary>
    /// 交易日期
    /// </summary>
    [Description("交易日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeDate;
    /// <summary>
    /// 交易时间
    /// </summary>
    [Description("交易时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeTime;
    /// <summary>
    /// 银行流水号
    /// </summary>
    [Description("银行流水号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String BankSerial;
    /// <summary>
    /// 交易系统日期 
    /// </summary>
    [Description("交易系统日期 ")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradingDay;
    /// <summary>
    /// 银期平台消息流水号
    /// </summary>
    [Description("银期平台消息流水号")]
    public int PlateSerial;
    /// <summary>
    /// 最后分片标志
    /// </summary>
    [Description("最后分片标志")]
    public CTPStockLastFragmentType LastFragment;
    /// <summary>
    /// 会话号
    /// </summary>
    [Description("会话号")]
    public int SessionID;
    /// <summary>
    /// 客户姓名
    /// </summary>
    [Description("客户姓名")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
    public String CustomerName;
    /// <summary>
    /// 证件类型
    /// </summary>
    [Description("证件类型")]
    public CTPStockIdCardType IdCardType;
    /// <summary>
    /// 证件号码
    /// </summary>
    [Description("证件号码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
    public String IdentifiedCardNo;
    /// <summary>
    /// 客户类型
    /// </summary>
    [Description("客户类型")]
    public CTPStockCustType CustType;
    /// <summary>
    /// 银行帐号
    /// </summary>
    [Description("银行帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String BankAccount;
    /// <summary>
    /// 银行密码
    /// </summary>
    [Description("银行密码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String BankPassWord;
    /// <summary>
    /// 投资者帐号
    /// </summary>
    [Description("投资者帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String AccountID;
    /// <summary>
    /// 期货密码
    /// </summary>
    [Description("期货密码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String Password;
    /// <summary>
    /// 期货公司流水号
    /// </summary>
    [Description("期货公司流水号")]
    public int FutureSerial;
    /// <summary>
    /// 安装编号
    /// </summary>
    [Description("安装编号")]
    public int InstallID;
    /// <summary>
    /// 用户标识
    /// </summary>
    [Description("用户标识")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;
    /// <summary>
    /// 验证客户证件号码标志
    /// </summary>
    [Description("验证客户证件号码标志")]
    public CTPStockYesNoIndicatorType VerifyCertNoFlag;
    /// <summary>
    /// 币种代码
    /// </summary>
    [Description("币种代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String CurrencyID;
    /// <summary>
    /// 摘要
    /// </summary>
    [Description("摘要")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
    public String Digest;
    /// <summary>
    /// 银行帐号类型
    /// </summary>
    [Description("银行帐号类型")]
    public CTPStockBankAccType BankAccType;
    /// <summary>
    /// 渠道标志
    /// </summary>
    [Description("渠道标志")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public String DeviceID;
    /// <summary>
    /// 期货单位帐号类型
    /// </summary>
    [Description("期货单位帐号类型")]
    public CTPStockBankAccType BankSecuAccType;
    /// <summary>
    /// 期货公司银行编码
    /// </summary>
    [Description("期货公司银行编码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
    public String BrokerIDByBank;
    /// <summary>
    /// 期货单位帐号
    /// </summary>
    [Description("期货单位帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String BankSecuAcc;
    /// <summary>
    /// 银行密码标志
    /// </summary>
    [Description("银行密码标志")]
    public CTPStockPwdFlagType BankPwdFlag;
    /// <summary>
    /// 期货资金密码核对标志
    /// </summary>
    [Description("期货资金密码核对标志")]
    public CTPStockPwdFlagType SecuPwdFlag;
    /// <summary>
    /// 交易柜员
    /// </summary>
    [Description("交易柜员")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
    public String OperNo;
    /// <summary>
    /// 请求编号
    /// </summary>
    [Description("请求编号")]
    public int RequestID;
    /// <summary>
    /// 交易ID
    /// </summary>
    [Description("交易ID")]
    public int TID;
    /// <summary>
    /// 银行可用金额
    /// </summary>
    [Description("银行可用金额")]
    public double BankUseAmount;
    /// <summary>
    /// 银行可取金额
    /// </summary>
    [Description("银行可取金额")]
    public double BankFetchAmount;
    /// <summary>
    /// 错误代码
    /// </summary>
    [Description("错误代码")]
    public int ErrorID;
    /// <summary>
    /// 错误信息
    /// </summary>
    [Description("错误信息")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
    public String ErrorMsg;

  };

  /// <summary>
  /// 银期转账交易流水表
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcTransferSerialField
  {
    /// <summary>
    /// 平台流水号
    /// </summary>
    [Description("平台流水号")]
    public int PlateSerial;
    /// <summary>
    /// 交易发起方日期
    /// </summary>
    [Description("交易发起方日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeDate;
    /// <summary>
    /// 交易日期
    /// </summary>
    [Description("交易日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradingDay;
    /// <summary>
    /// 交易时间
    /// </summary>
    [Description("交易时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeTime;
    /// <summary>
    /// 交易代码
    /// </summary>
    [Description("交易代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public String TradeCode;
    /// <summary>
    /// 会话编号
    /// </summary>
    [Description("会话编号")]
    public int SessionID;
    /// <summary>
    /// 银行编码
    /// </summary>
    [Description("银行编码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String BankID;
    /// <summary>
    /// 银行分支机构编码
    /// </summary>
    [Description("银行分支机构编码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public String BankBranchID;
    /// <summary>
    /// 银行帐号类型
    /// </summary>
    [Description("银行帐号类型")]
    public CTPStockBankAccType BankAccType;
    /// <summary>
    /// 银行帐号
    /// </summary>
    [Description("银行帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String BankAccount;
    /// <summary>
    /// 银行流水号
    /// </summary>
    [Description("银行流水号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String BankSerial;
    /// <summary>
    /// 期货公司编码
    /// </summary>
    [Description("期货公司编码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 期商分支机构代码
    /// </summary>
    [Description("期商分支机构代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String BrokerBranchID;
    /// <summary>
    /// 期货公司帐号类型
    /// </summary>
    [Description("期货公司帐号类型")]
    public CTPStockFutureAccType FutureAccType;
    /// <summary>
    /// 投资者帐号
    /// </summary>
    [Description("投资者帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String AccountID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 期货公司流水号
    /// </summary>
    [Description("期货公司流水号")]
    public int FutureSerial;
    /// <summary>
    /// 证件类型
    /// </summary>
    [Description("证件类型")]
    public CTPStockIdCardType IdCardType;
    /// <summary>
    /// 证件号码
    /// </summary>
    [Description("证件号码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
    public String IdentifiedCardNo;
    /// <summary>
    /// 币种代码
    /// </summary>
    [Description("币种代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String CurrencyID;
    /// <summary>
    /// 交易金额
    /// </summary>
    [Description("交易金额")]
    public double TradeAmount;
    /// <summary>
    /// 应收客户费用
    /// </summary>
    [Description("应收客户费用")]
    public double CustFee;
    /// <summary>
    /// 应收期货公司费用
    /// </summary>
    [Description("应收期货公司费用")]
    public double BrokerFee;
    /// <summary>
    /// 有效标志
    /// </summary>
    [Description("有效标志")]
    public CTPStockAvailabilityFlagType AvailabilityFlag;
    /// <summary>
    /// 操作员
    /// </summary>
    [Description("操作员")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
    public String OperatorCode;
    /// <summary>
    /// 新银行帐号
    /// </summary>
    [Description("新银行帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
    public String BankNewAccount;
    /// <summary>
    /// 错误代码
    /// </summary>
    [Description("错误代码")]
    public int ErrorID;
    /// <summary>
    /// 错误信息
    /// </summary>
    [Description("错误信息")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
    public String ErrorMsg;

  };

  /// <summary>
  /// 请求查询转帐流水
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcQryTransferSerialField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者帐号
    /// </summary>
    [Description("投资者帐号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String AccountID;
    /// <summary>
    /// 银行编码
    /// </summary>
    [Description("银行编码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String BankID;

  };

  /// <summary>
  /// 期商签到通知
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcNotifyFutureSignInField
  {
    /// <summary>
    /// 业务功能码
    /// </summary>
    [Description("业务功能码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public String TradeCode;
    /// <summary>
    /// 银行代码
    /// </summary>
    [Description("银行代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String BankID;
    /// <summary>
    /// 银行分支机构代码
    /// </summary>
    [Description("银行分支机构代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public String BankBranchID;
    /// <summary>
    /// 期商代码
    /// </summary>
    [Description("期商代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 期商分支机构代码
    /// </summary>
    [Description("期商分支机构代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String BrokerBranchID;
    /// <summary>
    /// 交易日期
    /// </summary>
    [Description("交易日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeDate;
    /// <summary>
    /// 交易时间
    /// </summary>
    [Description("交易时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeTime;
    /// <summary>
    /// 银行流水号
    /// </summary>
    [Description("银行流水号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String BankSerial;
    /// <summary>
    /// 交易系统日期 
    /// </summary>
    [Description("交易系统日期 ")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradingDay;
    /// <summary>
    /// 银期平台消息流水号
    /// </summary>
    [Description("银期平台消息流水号")]
    public int PlateSerial;
    /// <summary>
    /// 最后分片标志
    /// </summary>
    [Description("最后分片标志")]
    public CTPStockLastFragmentType LastFragment;
    /// <summary>
    /// 会话号
    /// </summary>
    [Description("会话号")]
    public int SessionID;
    /// <summary>
    /// 安装编号
    /// </summary>
    [Description("安装编号")]
    public int InstallID;
    /// <summary>
    /// 用户标识
    /// </summary>
    [Description("用户标识")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;
    /// <summary>
    /// 摘要
    /// </summary>
    [Description("摘要")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
    public String Digest;
    /// <summary>
    /// 币种代码
    /// </summary>
    [Description("币种代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String CurrencyID;
    /// <summary>
    /// 渠道标志
    /// </summary>
    [Description("渠道标志")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public String DeviceID;
    /// <summary>
    /// 期货公司银行编码
    /// </summary>
    [Description("期货公司银行编码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
    public String BrokerIDByBank;
    /// <summary>
    /// 交易柜员
    /// </summary>
    [Description("交易柜员")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
    public String OperNo;
    /// <summary>
    /// 请求编号
    /// </summary>
    [Description("请求编号")]
    public int RequestID;
    /// <summary>
    /// 交易ID
    /// </summary>
    [Description("交易ID")]
    public int TID;
    /// <summary>
    /// 错误代码
    /// </summary>
    [Description("错误代码")]
    public int ErrorID;
    /// <summary>
    /// 错误信息
    /// </summary>
    [Description("错误信息")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
    public String ErrorMsg;
    /// <summary>
    /// PIN密钥
    /// </summary>
    [Description("PIN密钥")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
    public String PinKey;
    /// <summary>
    /// MAC密钥
    /// </summary>
    [Description("MAC密钥")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
    public String MacKey;

  };

  /// <summary>
  /// 期商签退通知
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcNotifyFutureSignOutField
  {
    /// <summary>
    /// 业务功能码
    /// </summary>
    [Description("业务功能码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public String TradeCode;
    /// <summary>
    /// 银行代码
    /// </summary>
    [Description("银行代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String BankID;
    /// <summary>
    /// 银行分支机构代码
    /// </summary>
    [Description("银行分支机构代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public String BankBranchID;
    /// <summary>
    /// 期商代码
    /// </summary>
    [Description("期商代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 期商分支机构代码
    /// </summary>
    [Description("期商分支机构代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String BrokerBranchID;
    /// <summary>
    /// 交易日期
    /// </summary>
    [Description("交易日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeDate;
    /// <summary>
    /// 交易时间
    /// </summary>
    [Description("交易时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeTime;
    /// <summary>
    /// 银行流水号
    /// </summary>
    [Description("银行流水号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String BankSerial;
    /// <summary>
    /// 交易系统日期 
    /// </summary>
    [Description("交易系统日期 ")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradingDay;
    /// <summary>
    /// 银期平台消息流水号
    /// </summary>
    [Description("银期平台消息流水号")]
    public int PlateSerial;
    /// <summary>
    /// 最后分片标志
    /// </summary>
    [Description("最后分片标志")]
    public CTPStockLastFragmentType LastFragment;
    /// <summary>
    /// 会话号
    /// </summary>
    [Description("会话号")]
    public int SessionID;
    /// <summary>
    /// 安装编号
    /// </summary>
    [Description("安装编号")]
    public int InstallID;
    /// <summary>
    /// 用户标识
    /// </summary>
    [Description("用户标识")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;
    /// <summary>
    /// 摘要
    /// </summary>
    [Description("摘要")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
    public String Digest;
    /// <summary>
    /// 币种代码
    /// </summary>
    [Description("币种代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String CurrencyID;
    /// <summary>
    /// 渠道标志
    /// </summary>
    [Description("渠道标志")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public String DeviceID;
    /// <summary>
    /// 期货公司银行编码
    /// </summary>
    [Description("期货公司银行编码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
    public String BrokerIDByBank;
    /// <summary>
    /// 交易柜员
    /// </summary>
    [Description("交易柜员")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
    public String OperNo;
    /// <summary>
    /// 请求编号
    /// </summary>
    [Description("请求编号")]
    public int RequestID;
    /// <summary>
    /// 交易ID
    /// </summary>
    [Description("交易ID")]
    public int TID;
    /// <summary>
    /// 错误代码
    /// </summary>
    [Description("错误代码")]
    public int ErrorID;
    /// <summary>
    /// 错误信息
    /// </summary>
    [Description("错误信息")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
    public String ErrorMsg;

  };

  /// <summary>
  /// 交易核心向银期报盘发出密钥同步处理结果的通知
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcNotifySyncKeyField
  {
    /// <summary>
    /// 业务功能码
    /// </summary>
    [Description("业务功能码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
    public String TradeCode;
    /// <summary>
    /// 银行代码
    /// </summary>
    [Description("银行代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
    public String BankID;
    /// <summary>
    /// 银行分支机构代码
    /// </summary>
    [Description("银行分支机构代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
    public String BankBranchID;
    /// <summary>
    /// 期商代码
    /// </summary>
    [Description("期商代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 期商分支机构代码
    /// </summary>
    [Description("期商分支机构代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String BrokerBranchID;
    /// <summary>
    /// 交易日期
    /// </summary>
    [Description("交易日期")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeDate;
    /// <summary>
    /// 交易时间
    /// </summary>
    [Description("交易时间")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradeTime;
    /// <summary>
    /// 银行流水号
    /// </summary>
    [Description("银行流水号")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
    public String BankSerial;
    /// <summary>
    /// 交易系统日期 
    /// </summary>
    [Description("交易系统日期 ")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
    public String TradingDay;
    /// <summary>
    /// 银期平台消息流水号
    /// </summary>
    [Description("银期平台消息流水号")]
    public int PlateSerial;
    /// <summary>
    /// 最后分片标志
    /// </summary>
    [Description("最后分片标志")]
    public CTPStockLastFragmentType LastFragment;
    /// <summary>
    /// 会话号
    /// </summary>
    [Description("会话号")]
    public int SessionID;
    /// <summary>
    /// 安装编号
    /// </summary>
    [Description("安装编号")]
    public int InstallID;
    /// <summary>
    /// 用户标识
    /// </summary>
    [Description("用户标识")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public String UserID;
    /// <summary>
    /// 交易核心给银期报盘的消息
    /// </summary>
    [Description("交易核心给银期报盘的消息")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
    public String Message;
    /// <summary>
    /// 渠道标志
    /// </summary>
    [Description("渠道标志")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public String DeviceID;
    /// <summary>
    /// 期货公司银行编码
    /// </summary>
    [Description("期货公司银行编码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
    public String BrokerIDByBank;
    /// <summary>
    /// 交易柜员
    /// </summary>
    [Description("交易柜员")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
    public String OperNo;
    /// <summary>
    /// 请求编号
    /// </summary>
    [Description("请求编号")]
    public int RequestID;
    /// <summary>
    /// 交易ID
    /// </summary>
    [Description("交易ID")]
    public int TID;
    /// <summary>
    /// 错误代码
    /// </summary>
    [Description("错误代码")]
    public int ErrorID;
    /// <summary>
    /// 错误信息
    /// </summary>
    [Description("错误信息")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
    public String ErrorMsg;

  };

  /// <summary>
  /// 客户最大持仓数量
  /// </summary>
  [StructLayout(LayoutKind.Sequential)]
  public struct CZQThostFtdcMaxStockPositionAmountField
  {
    /// <summary>
    /// 经纪公司代码
    /// </summary>
    [Description("经纪公司代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
    public String BrokerID;
    /// <summary>
    /// 投资者代码
    /// </summary>
    [Description("投资者代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public String InvestorID;
    /// <summary>
    /// 合约代码
    /// </summary>
    [Description("合约代码")]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
    public String InstrumentID;
    /// <summary>
    /// 最大持仓数量
    /// </summary>
    [Description("最大持仓数量")]
    public int MaxAmount;

  };


}
