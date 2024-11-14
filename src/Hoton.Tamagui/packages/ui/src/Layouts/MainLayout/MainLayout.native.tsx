import { Tabs } from 'expo-router'
import { Home, User } from '@tamagui/lucide-icons'

export default function Layout() {
  return (
    <Tabs>
      <Tabs.Screen
        name="index"
        options={{
          title: '首頁',
          tabBarIcon: ({ color }) => <Home color={color as any} />,
        }}
      />
      {/* <Tabs.Screen name="hot-sale" />
      <Tabs.Screen name="subscriptions" />
      <Tabs.Screen name="cart" /> */}
      <Tabs.Screen
        name="member-center"
        options={{ title: '會員中心', tabBarIcon: ({ color }) => <User color={color as any} /> }}
      />
    </Tabs>
  )
}
