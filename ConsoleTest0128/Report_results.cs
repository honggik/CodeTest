using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleTest0128
{
    // 신고 결과 받기
	class Report_results
	{
        public static int[] solution(string[] id_list, string[] report, int k)
            {
                // 중복 신고 제거
                List<string> reportList = report.ToList().Distinct().ToList();
                // 신고 당한 사람 리스트
                Dictionary<string, int> reportCountLog = new Dictionary<string, int>();
                // 신고한 사람이 누굴 신고했는지 보는 리스트
                Dictionary<string, List<string>> reportLog = new Dictionary<string, List<string>>();
                // 메일 보내기 위한 사람들 리스트
                Dictionary<string, int> result = new Dictionary<string, int>();

                // 초기화
                foreach (string id in id_list)
                {
                    reportCountLog[id] = 0;
                    reportLog[id] = new List<string>();
                    result[id] = 0;
                }

                // 신고 리스트를 반복문 돌리고 split 해서 Dictionary 정리
                foreach (string reportItem in reportList)
                {
                    var split = reportItem.Split(' ');
                    ++reportCountLog[split[1]];
                    reportLog[split[0]].Add(split[1]);
                }

                // k 번 이상 신고당한 사람만 추려서 반복문 돌리고
                // 해당 사람을 신고한 사람한테 메일 보낼 카운트 증가
                // 딕셔너리를 value 조건?

                foreach (var countLog in reportCountLog.Where((e) => e.Value >= k))
                {
                    //if(countLog.Value>=k)
                    // 이런식으로 풀어도 되고 
                    foreach (var log in reportLog)
                    {
                        if (log.Value.Contains(countLog.Key))
                        {
                            ++result[log.Key];
                        }
                    }
                }

                return result.Values.ToArray();
            }
        
        static void Main()
		{
            
			string[] id_list1 = { "muzi", "frodo", "appech", "neo" };
			string[] report1 = { "muzi", "frodo", "appech frodo", "frodo neo", "muzi neo", "appech muzi" };

			int k1 = 2;
			Console.WriteLine( solution(id_list1,report1,k1));
		}
	}

}
